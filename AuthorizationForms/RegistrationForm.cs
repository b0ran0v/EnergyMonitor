using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyMonitor.AuthorizationForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = username_tbx.Text;
            string password = password_tbx.Text;
            string query = $"SELECT COUNT(*) FROM User WHERE Username='{username}';";

            MainForm.conn = new SQLiteConnection(@"data source = mydb.db");
            MainForm.command = new SQLiteCommand(query, MainForm.conn);

            try
            {
                MainForm.conn.Open();
                int UserExist = int.Parse(MainForm.command.ExecuteScalar().ToString());
                if (UserExist > 0)
                {
                    MainForm.conn.Close();
                    MessageBox.Show("User with such username already exists.\nTry another username.");
                }
                else
                {
                    MainForm.command.CommandText = $"INSERT INTO User (username, password) VALUES ('{username}', '{password}');";
                    MainForm.command.ExecuteNonQuery();
                    MessageBox.Show("New user is succesfully created.");
                    MainForm.conn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MainForm.conn.Close();
            }
            finally
            {
                username_tbx.Text = password_tbx.Text = string.Empty;
            }
        }
    }
}
