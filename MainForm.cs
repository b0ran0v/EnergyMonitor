using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using EnergyMonitor.Weather;
using EnergyMonitor.Geolocation;
using System.IO;
using System.Threading.Tasks;

namespace EnergyMonitor
{
    public partial class MainForm : Form
    {
        internal static SQLiteConnection conn = new SQLiteConnection(@"data source = mydb.db");
        internal static SQLiteCommand command;
        static string query;

        internal static string currentWeather;
        public MainForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weatherMonitor = new Thread(Monitor);
            weatherMonitor.Start();
        }

        public void RefreshData()
        {
            //Control Panel
            query = "SELECT * FROM Energy";
            command = new SQLiteCommand(query, conn);
            try
            {
                conn.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string typeId = string.Empty;
                    double capacityFull = double.Parse(reader["CapacityFull"].ToString());
                    double capacityCurrent = double.Parse(reader["CapacityCurrent"].ToString());
                    int capacityPercentage = Convert.ToInt32((capacityCurrent * 100) / capacityFull);
                    switch (reader["TypeId"].ToString())
                    {
                        case "1":
                            sp_prb.Value = capacityPercentage;
                            sp_tbx.Text = capacityPercentage.ToString();
                            sp_prb.ForeColor = SetColor(sp_prb.Value);
                            sp_chb.Checked = int.Parse(reader["Enabled"].ToString())==1 ? true : false;
                            sp_chb.Text = sp_chb.Checked ? "Turned on" : "Turned off";
                            break;

                        case "2":
                            wm_prb.Value = capacityPercentage;
                            wm_tbx.Text = capacityPercentage.ToString();
                            wm_prb.ForeColor = SetColor(wm_prb.Value);
                            wm_chb.Checked = int.Parse(reader["Enabled"].ToString())==1 ? true : false;
                            wm_chb.Text = wm_chb.Checked ? "Turned on" : "Turned off";
                            break;

                        case "3":
                            gr_prb.Value = capacityPercentage;
                            gr_tbx.Text = capacityPercentage.ToString();
                            gr_prb.ForeColor = SetColor(gr_prb.Value);
                            gr_chb.Checked = int.Parse(reader["Enabled"].ToString())==1 ? true : false;
                            gr_chb.Text = gr_chb.Checked ? "Turned on" : "Turned off";
                            break;
                    }
                }
                reader.Close();

                //Consumed Energy Display
                command.CommandText = "SELECT SUM(Amount) FROM EnergyConsumedLog";
                string consumedValue = command.ExecuteScalar().ToString();
                energyConsumed_lbl.Text = $"Energy Consumed:\n{consumedValue} kWt";

                //Produced Energy Display
                command.CommandText = "SELECT SUM(Amount) FROM EnergyProducedLog";
                string producedValue = command.ExecuteScalar().ToString();
                energyProduced_lbl.Text = $"Energy Produced:\n{producedValue} kWt";

                //Geolocation
                currentCity_lbl.Text = $"Current city: {GeolocationInformation.GetCity()}";

                //Weather
                weatherInformation_tbx.Text = WeatherInformation.PrintWeather();
                setCurrentWeather();

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void checkBox_Checked(Object sender, EventArgs e)
        {
            int typeId = 0;
            CheckBox checkBox = sender as CheckBox;
            switch(checkBox.Name)
            {
                case "sp_chb":
                    sp_chb.Text = sp_chb.Checked ? "Turned on" : "Turned off";
                    typeId = 1;
                    break;

                case "wm_chb":
                    wm_chb.Text = wm_chb.Checked ? "Turned on" : "Turned off";
                    typeId = 2;
                    break;

                case "gr_checkbox":
                    gr_chb.Text = gr_chb.Checked ? "Turned on" : "Turned off";
                    typeId = 3;
                    break;
            }

            int status = checkBox.Checked ? 1 : 0;

            if (status == 1)
            {
                if (typeId == 1 && !Windmills.isRecommended()) 
                    MessageBox.Show("Solar panels are not recommended to be turned on");
                else if(typeId == 2 && !Windmills.isRecommended())
                    MessageBox.Show("Windmills are not recommended to be turned on");
                else if (typeId == 3 && !Windmills.isRecommended())
                    MessageBox.Show("Grids are not recommended to be turned on");
            }

            try
            {
                conn.Open();
                query = $"UPDATE Energy SET Enabled={status} WHERE TypeId={typeId}";
                command.CommandText = query;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Color SetColor(int value)
        {
            if (value > 0 && value < 20) return Color.Red;
            else if (value >= 20 && value < 50) return Color.Yellow;
            else if (value >= 50 && value < 90) return Color.SeaGreen;
            else if (value >= 90) return Color.Green;
            return Color.Gray;
        }

        private void weather_btn_Click(object sender, EventArgs e)
        {
            weatherInformation_tbx.Text = string.Empty;
            weatherInformation_tbx.Text = WeatherInformation.PrintWeather();
        }

        private void use_btn_Click(object sender, EventArgs e)
        {
            int typeId = 0;
            TextBox tbx = null;
            Button button = sender as Button;
            switch (button.Name)
            {
                case "sp_use_btn":
                    typeId = 1;
                    tbx = sp_tbx;
                    break;
                case "wm_use_btn":
                    typeId = 2;
                    tbx = wm_tbx;
                    break;
                case "gr_use_btn":
                    typeId = 3;
                    tbx = gr_tbx;
                    break;
            }

            if (int.Parse(tbx.Text) >= 10)
            {
                command.CommandText = $"UPDATE Energy SET CapacityCurrent=(CapacityCurrent-10) WHERE TypeId={typeId}";
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    command.CommandText = $"INSERT INTO EnergyConsumedLog (EnergyType, Amount) VALUES ({typeId}, {10})";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Solar panel energy used");
                    conn.Close();
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Solar panels doesn't have enough energy to use");
        }

        private void setCurrentWeather()
        {
            string[] splited = currentWeather.Split('-');
            
            temperature_lbl.Text = $"Temperature: {splited[2].Trim()}";
            windSpeed_lbl.Text = $"Wind speed: {splited[4].Trim()}";
            humidity_lbl.Text = $"Humidity: {splited[5].Trim()}";
            string description = splited[1].Trim();
            currentWeather_lbl.Text = $"Current weather: {description}";
            switch (description)
            {
                case "clear sky":
                    weather_pictureBox.ImageLocation = "Images/clear_sky.jpg";
                    break;
                case "scattered clouds":
                    weather_pictureBox.ImageLocation = "Images/scattered_clouds.jpg";
                    break;
                case "broken clouds":
                    weather_pictureBox.ImageLocation = "Images/broken_clouds.jpg";
                    break;
            }
        }


        //Thread functions

        private static Thread weatherMonitor;
        protected delegate void setTextValue(CheckBox cb, string value);
        protected delegate void setCheckState(CheckBox cb, bool value);

        public void checBoxSetTextValue(CheckBox cb, string value)
        {
            if (this.InvokeRequired) this.Invoke(new setTextValue(checBoxSetTextValue), cb, value);
            else cb.Text = value;
        }

        public void checBoxSetCheckState(CheckBox cb, bool value)
        {
            if (this.InvokeRequired) this.Invoke(new setCheckState(checBoxSetCheckState), cb, value);
            else cb.Checked = value;
        }

        private void Monitor()
        {
            int status = 0;
            bool isRecommended = false;
            while (true)
            {
                Thread.Sleep(5000);
                isRecommended = !Windmills.isRecommended();
                if (wm_chb.Checked != isRecommended)
                {
                    checBoxSetCheckState(wm_chb, isRecommended);
                    checBoxSetTextValue(wm_chb, wm_chb.Checked ? "Turned on" : "Turned off");
                    status = wm_chb.Checked ? 1 : 0;
                    try
                    {
                        conn.Open();
                        query = $"UPDATE Energy SET Enabled={status} WHERE TypeId=2";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private async Task Produce()
        {
            while (true)
            {
                Thread.Sleep(10000);
                int counter = 0;
                bool[] produce = new bool[3];
                command.CommandText = "SELECT Enabled, CapacityCurrent FROM Energy";
                try
                {
                    conn.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string isEnabled = reader["Enabled"].ToString();
                        int capacityCurrent = int.Parse(reader["CapacityCurrent"].ToString());
                        if (isEnabled == "1" && capacityCurrent <= 95)
                        {
                            produce[counter] = true;
                        }
                        counter++;
                    }

                    reader.Close();
                    for (int i = 0; i < produce.Length; i++)
                    {
                        if (produce[i])
                        {
                            command.CommandText = $"INSERT INTO EnergyProducedLog (EnergyType, Amount) VALUES ({i + 1}, 1)";
                            command.ExecuteNonQuery();
                            command.CommandText = $"UPDATE Energy SET CapacityCurrent=(CapacityCurrent+1) WHERE TypeId={i + 1}";
                            command.ExecuteNonQuery();
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() => RefreshData()));
                    }
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
