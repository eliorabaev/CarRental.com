using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carental_Limited.Backend.Model;
using CarRental.Frontend;

namespace Carental_Limited
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tex(object sender, EventArgs e)
        {
        }

        private void textBox1_click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel2.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel1.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter Username");
            }
            if (!string.IsNullOrEmpty(textBox1.Text)&&string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter Password");
            }
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if(user =="admin" && pass=="admin")
            {
                LoadingScreen ls = new LoadingScreen();
                ls.Show();
                this.Hide();
            }
            else if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Wrong password");
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your managar");
        }
    }
}
