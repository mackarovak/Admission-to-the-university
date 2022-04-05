using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veryhelpfulsystem
{
    public class user
    {
        public int ID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public user(int ID, string login, string password)
        {
            this.ID = ID;
            this.login = login;
            this.password = password;
        }
    }
}
