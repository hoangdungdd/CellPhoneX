using CellPhoneX.Business;
using CellPhoneX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.View
{
    public class LoginView : IView
    {
        private readonly UserBL userbl;
        public LoginView()
        { 
            userbl = new UserBL();
           

        }
        public void Show()
        {
            ViewHelper.line("Login");
            User login = new User();
            while(true)
            {
                Console.Write("Username : ");
                login.username = Console.ReadLine();
                Console.Write("Password : ");
                login.password = ViewHelper.ReadPassword();
                bool resultLogin = userbl.login(login);
                if(resultLogin)
                {
                    Console.WriteLine("       Login Successful     ");
                    break;
                }
                else
                {
                    Console.WriteLine("      Error!    ");
                }
            }
            while(true)
            {
                new HubView().Hub();

            }    

        }
    }
}
