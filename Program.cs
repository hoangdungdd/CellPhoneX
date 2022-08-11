using CellPhoneX.Model;
using CellPhoneX.View;
using System;

namespace CellPhoneX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new MainView().Show();
         
            var user = new User
            {
                username = "kiem",
                password = "123"
            };

            var user2 = new User
            {
                username = "kiem",
                password = "123"
            };

            object user3 = new User();


            // neu khong ep duoc thi gan lai bang null
            var product = user3 as Product;

                    
            
            

            Console.WriteLine(user.Equals(user2));
            Console.ReadLine();


        }
    }
}
