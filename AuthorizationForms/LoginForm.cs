using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace EnergyMonitor.AuthorizationForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_tbx.Text;
            string password = password_tbx.Text;
            string query = $"SELECT COUNT(*) FROM User WHERE Username='{username}' AND Password='{password}';";

            MainForm.conn = new SQLiteConnection(@"data source = mydb.db");
            MainForm.command = new SQLiteCommand(query, MainForm.conn);
            try
            {
                MainForm.conn.Open();
                int UserExist = int.Parse(MainForm.command.ExecuteScalar().ToString());
                if (UserExist > 0)
                {
                    MainForm.conn.Close();
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("User with such username or password doesn't exist.\nTry again.");
                    MainForm.conn.Close();
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}
