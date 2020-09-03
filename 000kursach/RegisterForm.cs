using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
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

namespace _000kursach
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void Clear()
        {
            idBox.Text = "";
            loginBox.Text = "";
            passwordBox.Text = "";
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }
        private void BackPanel_MouseEnter(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.SpringGreen;
            BackButton.BackColor = Color.SpringGreen;
        }
        private void BackPanel_MouseLeave(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.Honeydew;
            BackButton.BackColor = Color.Honeydew;
        }
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.SpringGreen;
            BackPanel.BackColor = Color.SpringGreen;
        }
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.Honeydew;
            BackPanel.BackColor = Color.Honeydew;
        }
        private void LoadData()
        {
            DataBase db = new DataBase();
            MySqlConnection  connection = db.getConnection();
            connection.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            connection.Close();
            reader.Close();
            foreach (string[] s in data)
                UserGrid.Rows.Add(s);
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
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (loginCheck())
            {
                MessageBox.Show("Пользователь с введённым логином уже существует");
                return;
            }
            string role;
            if (adminRadio.Checked)
            {
                role = "admin";
            }
            else if (userRadio.Checked)
            {
                role = "user";
            }
            else
            {
                MessageBox.Show("Выбетите роль");
                return;
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `bd`.`users` (`login`, `password`, `role`) VALUES (@l, @p, @r)", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = passwordBox.Text;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = role;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("success");
            else
                MessageBox.Show("failure");
            db.closeConnection();
            UserGrid.Rows.Clear();
            LoadData();
            Clear();
        }
        public Boolean loginCheck()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginBox.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Для удаления профиля требуется ввести ID");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `users`.`id` = @i", db.getConnection());
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = idBox.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();

            }
            else
                MessageBox.Show("Отменено");
            UserGrid.Rows.Clear();
            LoadData();
            Clear();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<UserGrid.RowCount; i++)
            {
                UserGrid.Rows[i].Selected = false;
                for (int j =0; j<UserGrid.ColumnCount; j++)
                    if (UserGrid.Rows[i].Cells[j].Value != null)
                        if (UserGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            UserGrid.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            regTip.SetToolTip(registerButton, "Для регистрации должны укажите логин\nи пароль для нового пользователя");
        }
        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            regTip.SetToolTip(deleteButton, "Для удаления укажите ID");
        }
        private void redactorButton_MouseEnter(object sender, EventArgs e)
        {
            regTip.SetToolTip(redactorButton, "Для редактирования укажите ID пользователя\nи выберите новый логин и пароль");
        }
        private void redactorButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Для редактирования профиля требуется ввести ID");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите изменить пользователя?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `login` = @l, `password` = @p WHERE `users`.`id` = @i", db.getConnection());
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = idBox.Text;
                command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginBox.Text;
                command.Parameters.Add("@p", MySqlDbType.VarChar).Value = passwordBox.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            else
                MessageBox.Show("Отменено");
            UserGrid.Rows.Clear();
            LoadData();
            Clear();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserGrid.RowCount; i++)
            {
                UserGrid.Rows[i].Visible = false;
                for (int j = 0; j < UserGrid.ColumnCount; j++)
                    if (UserGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (UserGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            UserGrid.Rows[i].Visible = true;
                        }
                    }
            }
        }

        private void freeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserGrid.RowCount; i++)
                UserGrid.Rows[i].Visible = true;
            searchBox.Text = "";
        }

        private void UserGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in UserGrid.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                idBox.Text = row.Cells[0].Value.ToString();
                loginBox.Text = row.Cells[1].Value.ToString();
                passwordBox.Text = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
            }
        }
    }
}
