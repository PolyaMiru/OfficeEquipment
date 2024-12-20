using CaptchaGen.NetCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class Login : Form
    {
        string connectionString = DataBase.ConnectionString;
        string capcha;
        int countLogin;
        TimeSpan block = TimeSpan.FromMinutes(1);
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Login()
        {
            InitializeComponent();
        }
        private string GenCaptcha()
        {
            captchaTextBox.Text = string.Empty;
            string result = ImageFactory.CreateCode(6);
            captchaPictureBox.Image = Image.FromStream(ImageFactory.BuildImage(result, captchaPictureBox.Height, captchaPictureBox.Width, 40, 10));
            return result;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter($"EXEC login '{loginTextBox.Text}', '{passwordTextBox.Text}'", connection);
                    DataTable profile = new DataTable();
                    adapter.Fill(profile);
                    if (profile.Rows.Count <= 0)
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                        capthaPanel.Enabled = true;
                        capcha = GenCaptcha();
                        loginTextBox.Enabled = false;
                        passwordTextBox.Enabled = false;
                        loginButton.Enabled = false;
                        showButton.Enabled = false;
                        countLogin++;
                        if (countLogin == 4)
                        {
                            MessageBox.Show("Блокировка на три минуты!");

                            timer.Interval = 1000;
                            timer.Enabled = true;
                            timer.Tick += timer_Tick;
                            timer.Start();
                            loginTextBox.Enabled = false;
                            passwordTextBox.Enabled = false;
                            loginButton.Enabled = false;
                            capthaPanel.Enabled = false;
                            showButton.Enabled = false;
                        }
                        else if (countLogin == 5)
                        {
                            MessageBox.Show("Блокировка до перезапуска!");
                            loginTextBox.Enabled = false;
                            passwordTextBox.Enabled = false;
                            loginButton.Enabled = false;
                            capthaPanel.Enabled = false;
                            showButton.Enabled = false;
                        }
                    }
                    else
                    {
                       
                        int id_profile = int.Parse(profile.Rows[0][0].ToString());
                        int id_access = int.Parse(profile.Rows[0][1].ToString());
                        Hide();
                        switch (id_access)
                        {
                            case 1:
                                ShowRequestManager showRequestManager = new ShowRequestManager();
                                showRequestManager.ShowDialog();
                                break;
                            case 2:
                                ShowRequestOperator showRequestOperator = new ShowRequestOperator();
                                showRequestOperator.ShowDialog();
                                break;
                            case 3:
                                ShowRequestMaster showRequestMaster = new ShowRequestMaster(id_profile);
                                showRequestMaster.ShowDialog();
                                break;
                            case 4:
                                ShowRequest showRequest = new ShowRequest(id_profile);
                                showRequest.ShowDialog();
                                break;
                            default:
                                break;
                        }

                        Show();
                    }
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            block = block.Subtract(TimeSpan.FromSeconds(1));
            if (block.TotalSeconds == 0)
            {
                capthaPanel.Enabled = true;
                capcha = GenCaptcha();
                block = TimeSpan.FromMinutes(1);
            }
        }
        private void captchaButton_Click(object sender, EventArgs e)
        {
            if (captchaTextBox.Text != capcha)
            {
                MessageBox.Show("Неверная капча!");
            }
            else
            {
                capthaPanel.Enabled = false;
                loginTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                showButton.Enabled = true;
                loginButton.Enabled = true;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }

        }

        private void genButton_Click(object sender, EventArgs e)
        {
            capcha = GenCaptcha();
        }
    }
}
