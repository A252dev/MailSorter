using MailSorter;
using System;

namespace MailSorter
{
    class Program
    {        
        public static void Main()
        {
            Console.WriteLine("(っ◔◡◔)っ ♥ MailSorter ♥ \n ");
            Console.Write("Menu: \n Start \n About \n Exit \n\nWhat do you want: ");

            switch (Console.ReadLine())
            {
                case "Start":
                    Runner.Start();
                    break;
                case "About":
                    Runner.About();
                    break;
                case "Exit":
                    Console.Clear();
                    Console.WriteLine("Thanks for using us ;0");
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
        }
    }
}