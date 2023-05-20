using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine
{
    public partial class Blood_Bank : Form
    {
        public Blood_Bank()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            getBlood1.BringToFront();
            getBlood1.Show();
            homeBlood1.Hide();
            donateBlood1.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            donateBlood1.BringToFront();
            getBlood1.Hide();
            homeBlood1.Hide();
            donateBlood1.Show();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_two home_Two= new Home_two();
            home_Two.Show();
            getBlood1.Hide();
            homeBlood1.Hide();
            donateBlood1.Hide();

        }
    }
}
