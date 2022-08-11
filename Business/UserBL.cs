using CellPhoneX.DAL;
using CellPhoneX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.Business
{
    public class UserBL
    {
        public bool register(User user)
        {
            var cdal = new UserDAL();
            return cdal.InsertUser(user);
        }
        public bool login(User user)
        {
            var cdal =new UserDAL();
            return cdal.Login(user);
        }
    }
}
