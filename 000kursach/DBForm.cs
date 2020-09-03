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
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            textBoxDesign();
            LoadUpDown();
            LoadUpDown2();
            LoadNameData();
        }

        private void circularlabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для вставки введите дату, наименовение траспорта, количество проданых билетов, цену за один билет. Для редактирования введите номер исходной строки и изменяемые данные. Для удаления достаточно ввести номер строки.");
        }
        private void textBoxDesign()
        {
            nobox.Text = "номер";
            yearbox.Text = "год";
            namebox.Text = "название";
            ticketbox.Text = "количество билетов";
            pricebox.Text = "цена за билет";
            nobox.ForeColor = Color.Gray;
            yearbox.ForeColor = Color.Gray;
            namebox.ForeColor = Color.Gray;
            ticketbox.ForeColor = Color.Gray;
            pricebox.ForeColor = Color.Gray;
        }

        private void nobox_Enter(object sender, EventArgs e)
        {
            if (nobox.Text == "номер")
            {
                nobox.Text = "";
                nobox.ForeColor = Color.Black;
            }
        }
        private void nobox_Leave(object sender, EventArgs e)
        {
            if (nobox.Text == "")
            {
                nobox.Text = "номер";
                nobox.ForeColor = Color.Gray;
            }

        }

        private void datebox_Enter(object sender, EventArgs e)
        {
            if (yearbox.Text == "год")
            {
                yearbox.Text = "";
                yearbox.ForeColor = Color.Black;
            }
        }

        private void datebox_Leave(object sender, EventArgs e)
        {
            if (yearbox.Text == "")
            {
                yearbox.Text = "год";
                yearbox.ForeColor = Color.Gray;
            }
        }

        private void namebox_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == "название")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }
        }

        private void namebox_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                namebox.Text = "название";
                namebox.ForeColor = Color.Gray;
            }
        }

        private void ticketbox_Enter(object sender, EventArgs e)
        {
            if (ticketbox.Text == "количество билетов")
            {
                ticketbox.Text = "";
                ticketbox.ForeColor = Color.Black;
            }
        }

        private void ticketbox_Leave(object sender, EventArgs e)
        {
            if (ticketbox.Text == "")
            {
                ticketbox.Text = "количество билетов";
                ticketbox.ForeColor = Color.Gray;
            }
        }

        private void pricebox_Enter(object sender, EventArgs e)
        {
            if (pricebox.Text == "цена за билет")
            {
                pricebox.Text = "";
                pricebox.ForeColor = Color.Black;
            }
        }

        private void pricebox_Leave(object sender, EventArgs e)
        {
            if (pricebox.Text == "")
            {
                pricebox.Text = "цена за билет";
                pricebox.ForeColor = Color.Gray;
            }
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
            while(reader.Read())
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
        private void LoadData1()
        {
            DataBase db = new DataBase();
            MySqlConnection connection = db.getConnection();
            connection.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `names`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            connection.Close();
            foreach (string[] s in data)
                transportGrid.Rows.Add(s);
        }
        private void LoadNameData()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT name FROM names", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string slovo = reader[0].ToString();
                namebox.Items.Add(slovo);
            }
            reader.Close();
            db.closeConnection();
        }

        private void refreshData()
        {
            ticketGrid.Rows.Clear();
            LoadData();
            transportGrid.Rows.Clear();
            LoadData1();
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

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.SpringGreen;
            BackButton.BackColor = Color.SpringGreen;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackPanel.BackColor = Color.Honeydew;
            BackButton.BackColor = Color.Honeydew;
        }

        private void BackPanel_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.SpringGreen;
            BackPanel.BackColor = Color.SpringGreen;
        }

        private void BackPanel_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = Color.Honeydew;
            BackPanel.BackColor = Color.Honeydew;
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
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (yearbox.Text == "год"|| namebox.Text == "название" || ticketbox.Text == "количество билетов" || pricebox.Text == "цена за билет")
            {
                MessageBox.Show("Введенные данные не полные");
                return;
            }
            int month = domainUpDown2.SelectedIndex;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `transport` (`id`, `year`, `month`, `name`, `amount`, `price`) VALUES (NULL, @y, @m, @n, @a, @p)", db.getConnection());
            command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearbox.Text;
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = namebox.Text;
            command.Parameters.Add("@a", MySqlDbType.VarChar).Value = ticketbox.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pricebox.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("success");
            else
                MessageBox.Show("failure");
            db.closeConnection();
            refreshData();
            textBoxDesign();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nobox.Text == "номер")
            {
                MessageBox.Show("Для редактирования требуется ввести номер строки");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите внести изменения?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int month = domainUpDown2.SelectedIndex;
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `transport` SET `year` = @y, `month` = @m, `name` = @n, `amount` = @a, `price` = @p WHERE `transport`.`id` = @i", db.getConnection());
                command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearbox.Text;
                command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = namebox.Text;
                command.Parameters.Add("@a", MySqlDbType.VarChar).Value = ticketbox.Text;
                command.Parameters.Add("@p", MySqlDbType.VarChar).Value = pricebox.Text;
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = nobox.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            else
                MessageBox.Show("Отменено");
            refreshData();
            textBoxDesign();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nobox.Text == "номер")
            {
                MessageBox.Show("Для удаления требуется ввести номер");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить строку?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("DELETE FROM `transport` WHERE `transport`.`id` = @i", db.getConnection());
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = nobox.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();

            }
            else
                MessageBox.Show("Отменено");
            refreshData();
            textBoxDesign();
        }

        private void pricebox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pricebox, "Для ввода дробного числа\nиспользуйте . а не ,");
        }
        string path = @"D:\log.txt";
        private void priceButton_Click(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Выбор месяца")
            {
                MessageBox.Show("Выберите месяц");
                return;
            }
            double S = 0;
            int month = domainUpDown1.SelectedIndex;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT amount, price FROM transport WHERE month = @m AND year = @y", db.getConnection());
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
            command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearBoxEnter.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                S += double.Parse(reader[1].ToString()) * double.Parse(reader[0].ToString());
            }
            using (StreamWriter stream = new StreamWriter(path, true))
                stream.WriteLine("{1}) Результат последнего выполнения задачи \"Общий доход за выбранный месяц ({0})\"\n{2} BYN ", month + 1, DateTime.Now, S);
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
            int S = 0;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT amount FROM transport WHERE month = @m AND year = @y", db.getConnection());
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = month + 1;
            command.Parameters.Add("@y", MySqlDbType.VarChar).Value = yearBoxEnter.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                S++;
            }
            double[] top = new double[S];
            reader.Close();
            MySqlDataReader reader1 = command.ExecuteReader();
            int i = 0;
            while (reader1.Read() && i < S)
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

        private void LoadUpDown2()
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown2.Items;
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

        private void ticketGrid_SelectionChanged(object sender, EventArgs e) 
        {
            DataGridViewCell cell = null;
            foreach(DataGridViewCell selectedCell in ticketGrid.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                nobox.Text = row.Cells[0].Value.ToString();
                yearbox.Text = row.Cells[1].Value.ToString();
                domainUpDown2.Text = row.Cells[2].Value.ToString();
                namebox.Text = row.Cells[3].Value.ToString();
                ticketbox.Text = row.Cells[4].Value.ToString();
                pricebox.Text = row.Cells[5].Value.ToString();
                nobox.ForeColor = Color.Black;
                yearbox.ForeColor = Color.Black;
                namebox.ForeColor = Color.Black;
                ticketbox.ForeColor = Color.Black;
                pricebox.ForeColor = Color.Black;
            }
        }

        private void delete1button_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Для удаления требуется ввести номер", "Ошибка");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить строку?", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("DELETE FROM `names` WHERE `names`.`id` = @i", db.getConnection());
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = idBox.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            else
                MessageBox.Show("Отменено", "Уведомление");
            refreshData();
            textBoxDesign();
        }

        private void edit1button_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Для редактирования требуется ввести id строки", "Ошибка");
                return;
            }
            if (MessageBox.Show("Вы действительно хотите внести изменения?", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int month = domainUpDown2.SelectedIndex;
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `names` SET `name` = @n, `price` = @p WHERE `transport`.`id` = @i", db.getConnection());
                command.Parameters.Add("@i", MySqlDbType.VarChar).Value = idBox.Text;
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name1Box.Text;
                command.Parameters.Add("@p", MySqlDbType.VarChar).Value = price1Box.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            else
                MessageBox.Show("Отменено", "Уведомление");
            refreshData();
            textBoxDesign();
        }

        private void insert1button_Click(object sender, EventArgs e)
        {
            if (name1Box.Text == "" || price1Box.Text == "")
            {
                MessageBox.Show("Введенные данные не полные");
                return;
            }
            int month = domainUpDown2.SelectedIndex;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `names` (`id`, `name`, `price`) VALUES (NULL, @n, @p)", db.getConnection());
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name1Box.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = price1Box.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("success");
            else
                MessageBox.Show("failure");
            db.closeConnection();
            refreshData();
            textBoxDesign();
        }

        private void search1button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transportGrid.RowCount; i++)
            {
                ticketGrid.Rows[i].Selected = false;
                for (int j = 0; j < transportGrid.ColumnCount; j++)
                    if (ticketGrid.Rows[i].Cells[j].Value != null)
                        if (ticketGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            ticketGrid.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void filter1button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transportGrid.RowCount; i++)
            {
                transportGrid.Rows[i].Visible = false;
                for (int j = 0; j < transportGrid.ColumnCount; j++)
                    if (transportGrid.Rows[i].Cells[j].Value != null)
                    {
                        if (transportGrid.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            transportGrid.Rows[i].Visible = true;
                        }
                    }
            }
        }

        private void free1button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < transportGrid.RowCount; i++)
                transportGrid.Rows[i].Visible = true;
            search1box.Text = "";
        }

        private void namebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT price FROM names WHERE name=@n", db.getConnection());
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = namebox.SelectedItem.ToString();
            pricebox.Text = command.ExecuteScalar().ToString();
            db.closeConnection();
        }
    }
}
