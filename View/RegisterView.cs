using CellPhoneX.Business;
using CellPhoneX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.View
{
    public class RegisterView : IView
    {
        private readonly UserBL userbl;

        public RegisterView()
        {
            userbl = new UserBL();
        }
        public void Show()
        {
            ViewHelper.line("Register");
            bool validate = true;
            User register = new User();
            string re_password;
            do
            {
                Console.Write("Username : ");
                register.username = Console.ReadLine();
                Console.Write("Password : ");
                register.password = ViewHelper.ReadPassword();
                Console.Write("Re-password : ");
                re_password = ViewHelper.ReadPassword();
                validate = validateUser(register , re_password);
            } while (!validate);
            bool resultRegister = userbl.register(register);
            if(resultRegister)
            {
                Console.WriteLine("        Register Successful!     ");
                Router.route(nameof(MainView));
            } else
            {
                Console.WriteLine("   Error!  ");
            }

        }
        public bool validateUser(User user, string re_password)
        {
            if (user.password.Length <= 6)
            {
                Console.WriteLine("   Invalid ! ");
                return false;
            }
            if (user.username.Length <= 6)
            {
                Console.WriteLine("   Invalid ! ");
                return false;
            }

            if (user.password != re_password)
            {
                Console.WriteLine("   Invalid ! ");
                return false;
            }
            return true;


        }
      

    }
}
