using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _000kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = Color.Salmon;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.MistyRose;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            String login = loginBox.Text;
            String password = passwordBox.Text;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l AND `password` = @p", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (login == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (table.Rows.Count > 0)
            {   
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT role FROM users WHERE login = @l", db.getConnection());
                command1.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
                string role = command1.ExecuteScalar().ToString();
                db.closeConnection();
                if (role == "admin")
                {
                    this.Hide();
                    AdminMenu mainMenu = new AdminMenu();
                    mainMenu.Show();
                }
                else if (role == "user")
                {
                    this.Hide();
                    UserMenu userMenu = new UserMenu();
                    userMenu.Show();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
    }
}
