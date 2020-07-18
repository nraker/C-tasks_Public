using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBKeys
{
    public partial class LoginField : Form
    {
        
        public LoginField()
        {
            InitializeComponent();
        }

        private void LoginField_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = logField.Text;
            string passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (logField.TextLength > 0 && logField.TextLength > 0 && logField.Text != "Введите логин" && passField.Text != "Введите пароль" && char.IsUpper(passUser[0]))
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Yes");
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
            else if(!char.IsUpper(passUser[0]))
            {
                MessageBox.Show("Первая буква пароля должна быть заглавной");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            
        }

        private void logField_Leave(object sender, EventArgs e)
        {
            if(logField.Text == "")
            {
                logField.Text = "Введите логин";
                logField.ForeColor = Color.Gray;
            }
        }

        private void logField_Enter(object sender, EventArgs e)
        {
            if(logField.Text == "Введите логин")
            {
                logField.Text = "";
                
            }
            logField.ForeColor = Color.Black;
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
            }
            passField.ForeColor = Color.Black;
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
                passField.UseSystemPasswordChar = false;
            }
        }

        private void regField_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterField RegisterField = new RegisterField();
            RegisterField.Show();
        }

        private void LoginField_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void passField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void logField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
    }
}
