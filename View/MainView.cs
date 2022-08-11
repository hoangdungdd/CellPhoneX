using CellPhoneX.Model;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.View
{
    public class MainView : IView
    {
        public void Show()
        {
            
            int key;
            while (true)
            {
                var rule = new Rule("[blue]Welcome[/]").RuleStyle(new Style());
                AnsiConsole.Write(rule);
                //var title = new Panel(new FigletText("Welcome").Centered().Color(Color.Red))
                //    .BorderStyle(new Style(background: Color.Red));
                
                List<string> choices = new List<string>()
                {
                    "Register",
                    "login",
                    "Exit"
                };
                var result = AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
                    .AddChoices<string>(choices)
                    );
                key = choices.IndexOf(result) + 1;
                switch (key)
                {
                    case 1:

                        Router.route(nameof(RegisterView));
                        break;
                    case 2:
                        Router.route(nameof(LoginView));

                        break;
                    default:

                        break;
                }




            }

        }
      


    }
}
