using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.View
{
    public class HubView
    {
        public void Hub()
        {
            while (true)
            {
                ViewHelper.line("Hub");
                Console.WriteLine("1 . Shop ");
                Console.WriteLine("2 . Search ");

                Console.ReadLine();



            }
        }

    }
}
