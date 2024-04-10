using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Frontend;

namespace CarRental.Frontend
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading.Width += 3;
            if (Loading.Width >=500)
            {
                timer1.Stop();
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
