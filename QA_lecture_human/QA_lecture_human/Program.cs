using System;
using System.ComponentModel.Design;

namespace QA_lecture_human
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("This is Human market of apples and water");
            int option;
            do
            {
                option = menu.AskCharacter();
                menu.ShowCharacter(option);
                if (option != 5)
                {
                    int action;
                    do
                    {
                        action = menu.AskAction();
                        menu.Action(action);
                    } while (action != 9);
                }
            } while (option != 5);
        }
    }
}
