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

namespace LifeLine
{
    public partial class Secondary_Screen : Form
    {
        public Secondary_Screen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //signup button

            string file = "E:\\Important\\ProjectOOC\\LIFELINE\\LifeLine\\LifeLine";
            bool f1 = false;

            

            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach(string line in lines)
                {
                    if(line == signup_uname_tb.Text)
                    {
                        f1 = true;break;
                    }
                }
                if(!f1) 
                { 
                    if()
                }
            }
        }
    }
}
