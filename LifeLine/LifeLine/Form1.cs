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

            string filepass = "E:\\Important\\ProjectOOC\\LIFELINE\\LifeLine\\LifeLine\\upass.txt";
            string filename = "E:\\Important\\ProjectOOC\\New LifeLine\\LifeLine\\LifeLine\\uname.txt";


            bool usernameMatch = false, passwordMatch = false;

            if (File.Exists(filepass))
            {
                string[] lines = File.ReadAllLines(filepass);


                foreach (string line in lines)
                {
                    if (line == pass_tb.Text)
                    {
                        passwordMatch = true;
                    }

                }


            }
            if (File.Exists(filename))
            {
                string[] unames = File.ReadAllLines(filename);

                foreach (string name in unames)
                {
                    if (name == uname_tb.Text)
                    {
                        usernameMatch = true;
                    }
                }
            }

            if (usernameMatch && passwordMatch)
            {
                this.Hide();
                Home_two home_Two = new Home_two();
                home_Two.Show();
            }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
