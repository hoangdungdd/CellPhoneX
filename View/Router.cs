using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.View
{
    public static class Router
    {
        public static void route(string viewname)
        {
            Console.Clear();
            switch(viewname)
            {
                case nameof(MainView):
                    new MainView().Show();
                    break;
                case nameof(RegisterView):
                    new RegisterView().Show();
                    
                    break;
                case nameof(LoginView):
                    new LoginView().Show();
                    break;

                default:
                    new MainView().Show();
                    break;
            }
        }
    }
}
