using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _000kursach
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            ticketGrid.RowHeadersVisible = false;
            ticketGrid.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.DisplayedCells);
            LoadData();
            LoadUpDown();
        }
        private void LoadUpDown()
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("Январь");
            collection.Add("Февраль");
            collection.Add("Март");
            collection.Add("Апрель");
            collection.Add("Май");
            collection.Add("Июнь");
            collection.Add("Июль");
            collection.Add("Август");
            collection.Add("Сентябрь");
            collection.Add("Октябрь");
            collection.Add("Ноябрь");
            collection.Add("Декабрь");
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginMenu = new Form1();
            loginMenu.Show();
        }

        private void BackPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginMenu = new Form1();
            loginMenu.Show();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = Color.Salmon;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.MistyRose;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.SpringGreen;
            BackButton.BackColor = Color.SpringGreen;
        }

        private void BackPanel_MouseLeave(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.Honeydew;
            BackButton.BackColor = Color.Honeydew;
        }

        private void BackPanel_MouseEnter(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.SpringGreen;
            BackButton.BackColor = Color.SpringGreen;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.Honeydew;
            BackButton.BackColor = Color.Honeydew;
        }
        private void LoadData()
        {
            DataBase db = new DataBase();
            MySqlConnection connection = db.getConnection();
            connection.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `transport`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            connection.Close();
            foreach (string[] s in data)
                ticketGrid.Rows.Add(s);
        }

        string path = @"D:\log.txt";
        private void priceButton_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Выбор месяца")
            {
                MessageBox.Show("Выберите месяц");
                return;
            }
            double S=0;
            int month = domainUpDown1.SelectedIndex;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT amount, price FROM transport WHERE month = @m AND year = @y", db.getConnection());
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
            command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearBox.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                S += double.Parse(reader[1].ToString()) * double.Parse(reader[0].ToString());
            }
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine("{1}) Результат последнего выполнения задачи \"Общий доход за выбранный месяц ({0})\"\n{2} BYN ",month+1, DateTime.Now, S);
            resultBox.Text = S.ToString();
            reader.Close();
            MessageBox.Show("Файл с результатом сохранен в D:\\log.txt");
            db.closeConnection();
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            topList.Items.Clear();
            if (domainUpDown1.Text == "Выбор месяца")
            {
                MessageBox.Show("Выберите месяц");
                return;
            }
            int month = domainUpDown1.SelectedIndex;
            int S=0;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT amount FROM transport WHERE month = @m AND year = @y", db.getConnection());
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
            command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearBox.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                S++ ;
            }
            double[] top = new double[S];
            reader.Close();
            MySqlDataReader reader1 = command.ExecuteReader();
            int i = 0;
            while (reader1.Read() && i<S)
            {
                double slovo = double.Parse(reader1[0].ToString());
                top[i] = slovo;
                i++;
            }
            reader1.Close();
            Array.Sort(top);
            Array.Reverse(top);
            if (S > 5)
                S = 5;
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine("{0}) Результат последнего выполнения задачи \"Список востребованного транспорта за месяц\"", DateTime.Now);
                for (i = 0; i < S; i++)
                {
                    MySqlCommand command1 = new MySqlCommand("SELECT name FROM transport WHERE amount = @a", db.getConnection());
                    command1.Parameters.Add("@a", MySqlDbType.VarChar).Value = top[i];
                    string s = command1.ExecuteScalar().ToString();
                    string log = (i + 1) + ") " + s + " - " + top[i] + " билетов.";
                    topList.Items.Insert(i, log);
                    stream.WriteLine(log);
                }
            }
            MessageBox.Show("Файл с результатом сохранен в D:\\log.txt");
            db.closeConnection();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ticketGrid.RowCount; i++)
            {
                ticketGrid.Rows[i].Selected = false;
                for (int j = 0; j < ticketGrid.ColumnCount; j++)
                    if (ticketGrid.Rows[i].Cells[j].Value != null)
                        if (ticketGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            ticketGrid.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ticketGrid.RowCount; i++)
            {
                ticketGrid.Rows[i].Visible = false;
                for (int j = 0; j < ticketGrid.ColumnCount; j++)
                    if (ticketGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (ticketGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            ticketGrid.Rows[i].Visible = true;
                        }
                    }
            }
        }

        private void freeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ticketGrid.RowCount; i++)
                ticketGrid.Rows[i].Visible = true;
            searchBox.Text = "";
        }
    }
}
