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
            //Form2 abc = new Form2();
          //  abc.ShowDialog();
            ////Log form1 = new Log();
            ////form1.Show();
            Blood_Bank bloodBank = new Blood_Bank();
            bloodBank.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //signup button

            string filepass = "E:\\Important\\ProjectOOC\\New LifeLine\\LifeLine\\LifeLine\\upass.txt";
            string filename = "E:\\Important\\ProjectOOC\\New LifeLine\\LifeLine\\LifeLine\\uname.txt";
            bool f1 = false;

            

            if(File.Exists(filepass)  && File.Exists(filepass))
            {
                string[] lines = File.ReadAllLines(filepass);
                string[] names = File.ReadAllLines(filename);


                foreach(string name in names)
                {
                    if(String.Equals(name, signup_uname_tb.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        f1 = true;break;
                    }
                }
                
                if(!f1) 
                {
                    if (signup_pass_tb.Text == signup_pass_tb2.Text)
                    {
                        
                        
                        File.AppendAllText(filename, signup_uname_tb.Text);
                        File.AppendAllText(filename, "\n");


                        
                        File.AppendAllText(filepass, signup_pass_tb.Text);
                        File.AppendAllText(filepass, "\n");


                        Log log = new Log();
                        this.Hide();
                        log.Show();
                    }
                }
            }
        }
    }
}
