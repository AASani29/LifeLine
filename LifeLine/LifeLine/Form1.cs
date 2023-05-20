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
using static System.Windows.Forms.LinkLabel;

namespace LifeLine
{
    public partial class Log : Form
    {

        List<User> users = new List<User>();
        string path = @"C:\Users\Hp\Desktop\New LifeLine\";

        public Log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //click here to login linklabel
            Secondary_Screen secondary_screen = new Secondary_Screen();
            this.Hide();
            secondary_screen.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            // login button (1st ui)
            // we have to make a text file later with complete data

            bool f1  = false;

            string uname = uname_tb.Text;
            string upass = pass_tb.Text;

            StreamReader sr = new StreamReader(path + "user.txt");
            string text = sr.ReadLine();

            while(text != null)
            {
                string[] userfrags = text.Split(',');
                string name = userfrags[0];
                string pass = userfrags[1];

                if(uname==name && upass==pass)
                {
                    f1 = true;
                }

                text = sr.ReadLine();
            }
            




            if (f1)
            {
                this.Hide();
                Home_two home_Two = new Home_two();
                home_Two.Show();
            }


        }
    }
}
