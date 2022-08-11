using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.Model
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool is_admin { get; set; }
        public string name  { get; set; }
        public int balance { get; set; }
        public string phone { get; set; }

      

    }
}
