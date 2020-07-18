using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace DBKeys
{
    public partial class RegisterField : Form
    {
        public RegisterField()
        {
            InitializeComponent();
            logField.ForeColor = Color.Gray; passConfirmField.ForeColor = Color.Gray; passField.ForeColor = Color.Gray; mailField.ForeColor = Color.Gray;
            logField.Text = "Введите логин"; passConfirmField.Text = "Подтвердите пароль"; passField.Text = "Введите пароль"; mailField.Text = "Введите почту";
        }

        private void RegisterField_Load(object sender, EventArgs e)
        {
        }

        private void backToLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginField loginField = new LoginField();
            loginField.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userLogin = logField.Text, userPass = passField.Text, userCPass = passConfirmField.Text, userMail = mailField.Text;

            if (userPass == userCPass && (userPass.Length >= 8 && userCPass.Length >= 8) && userLogin.Length >= 6 && userMail.Length >= 6 && checkBox2.Checked && !checkUser() &&(char.IsUpper(userPass[0]) && char.IsUpper(userCPass[0])))
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `mail`) VALUES (@uLog, @uPass, @uMail)", db.getConnection());

                command.Parameters.Add("@uLog", MySqlDbType.VarChar).Value = userLogin;
                command.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = userPass;
                command.Parameters.Add("@uMail", MySqlDbType.VarChar).Value = userMail;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account created");
                    this.Hide();
                    LoginField loginField = new LoginField();
                    loginField.Show();
                }
                else
                {
                    MessageBox.Show("Account not created, try again");
                }

                db.closeConnection();
            }
            else if (userLogin.Length == 0 && userPass.Length == 0 && userCPass.Length == 0 && userMail.Length == 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else if (userLogin.Length < 6)
            {
                MessageBox.Show("Логин должен состоять из 6 и более знаков");
            }
            else if (userPass.Length < 8 || userCPass.Length < 8)
            {
                MessageBox.Show("Пароль должен состоять из 8 и более знаков");
            }
            else if (userMail.Length < 6)
            {
                MessageBox.Show("Почта должна состоять из 6 и более знаков");
            }
            else if (!char.IsUpper(userPass[0]) && !char.IsUpper(userCPass[0]))
            {
                MessageBox.Show("Пароль должен начинаться с заглавной буквы");
            }
            else if (userPass != userCPass)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else if (!checkBox2.Checked)
            {
                MessageBox.Show("Примите соглашение");
            }
        }

        private void RegisterField_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RegisterField_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                logField.Text = "";
                MessageBox.Show("Такой логин уже есть");
                return true;

            }
            else
                return false;
        }

        private void logField_Leave(object sender, EventArgs e)
        {
            if (logField.Text == "")
            {
                logField.Text = "Введите логин";
                logField.ForeColor = Color.Gray;
            }
        }

        private void logField_Enter(object sender, EventArgs e)
        {
            if (logField.Text == "Введите логин")
            {
                logField.Text = "";
            }

            logField.ForeColor = Color.Black;
        }
        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.ForeColor = Color.Gray;
                passField.Text = "Введите пароль";
                passField.UseSystemPasswordChar = false;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
            }
            passField.ForeColor = Color.Black;
            passField.UseSystemPasswordChar = true;
        }
        private void passConfirmField_Leave(object sender, EventArgs e)
        {
            if (passConfirmField.Text == "")
            {
                passConfirmField.Text = "Подтвердите пароль";
                passConfirmField.ForeColor = Color.Gray;
                passConfirmField.UseSystemPasswordChar = false;
            }
        }

        private void passConfirmField_Enter(object sender, EventArgs e)
        {
            if (passConfirmField.Text == "Подтвердите пароль")
            {
                passConfirmField.Text = "";
            }
            passConfirmField.ForeColor = Color.Black;
            passConfirmField.UseSystemPasswordChar = true;
        }
        private void mailField_Leave(object sender, EventArgs e)
        {
            if (mailField.Text == "")
            {
                mailField.ForeColor = Color.Gray;
                mailField.Text = "Введите почту";
            }
        }

        private void mailField_Enter(object sender, EventArgs e)
        {
            if (mailField.Text == "Введите почту")
            {
                mailField.Text = "";
            }
            mailField.ForeColor = Color.Black;
        }

        public void logField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        private void passField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        private void passConfirmField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        private void mailField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
    }
}
