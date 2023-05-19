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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Log form1 = new Log();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //signup button

            string file = "E:\\Important\\ProjectOOC\\New LifeLine\\LifeLine\\LifeLine\\username_pass.txt";
            bool f1 = false;

            

            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach(string line in lines)
                {
                    if(String.Equals(line, signup_uname_tb.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        f1 = true;break;
                    }
                }
                if(!f1) 
                {
                    if (signup_pass_tb.Text == signup_pass_tb2.Text)
                    {
                        File.AppendAllText(file, "\n");
                        File.AppendAllText(file, signup_uname_tb.Text);
                        File.AppendAllText(file, "\n");
                        File.AppendAllText(file, signup_pass_tb.Text);

                        Log log = new Log();
                        this.Hide();
                        log.Show();
                    }
                }
            }
        }
    }
}
