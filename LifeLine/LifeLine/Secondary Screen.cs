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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LifeLine
{
    public partial class Secondary_Screen : Form
    {
        List<User> users = new List<User>();
        string path = @"C:\Users\Hp\Desktop\New LifeLine\";


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
            
            if(signup_pass_tb.Text == signup_pass_tb2.Text)
            {
                string uname = signup_uname_tb.Text;
                string pass = signup_pass_tb.Text;
                long age = Convert.ToInt32(Ageinfotb.Text);
                string bgroup = Bloodtb.Text;
                string phoneNo = phonenotb.Text;
                string location = locationtb.Text;

                User u = new User(uname, pass, age, bgroup, phoneNo, location);
                users.Add(u);

                string k = $"{uname},{pass},{age},{bgroup},{phoneNo},{location}";

                StreamWriter sw = File.AppendText(path + "user.txt");
                sw.WriteLine(k);
                sw.Close();
            }
            
            





        }
    }
}
