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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginMenu = new Form1();
            loginMenu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Wheat;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.OldLace;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Wheat;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.OldLace;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DBForm dbForm = new DBForm();
            dbForm.Show();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Wheat;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.OldLace;
        }
    }
 }