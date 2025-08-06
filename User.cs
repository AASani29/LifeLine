using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeLine
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public long age { get; set; }

        public string bgroup { get; set; }
        public string phoneNo { get; set; }

        public string location { get; set; }
     
        public User(string username, string password, long age, string bgroup, string phoneNo, string location)
        {
            this.username = username;
            this.password = password;   
            this.age = age;
            this.bgroup = bgroup;
            this.phoneNo = phoneNo;
            this.location = location;

        }
    }
}
