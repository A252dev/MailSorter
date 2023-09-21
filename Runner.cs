using MailSorter;
using System;
using System.Text;

namespace MailSorter
{
    class Runner
    {
        public static void Start()
        {
            Console.Clear();
            string path = @"C:\Users\Agent\Desktop\mails.txt";
            if (!File.Exists(path))
            {
                Console.Clear();
                Console.WriteLine("You don't have 'mails.txt' file in your directory!");
            } else
            {
                Console.Write("Enter the ANY type of your mail (ex: outlook.com, gmail.com): ");
                string Select = Console.ReadLine();
                Console.WriteLine();
                int Score = 0;

                using (FileStream scanner = File.OpenRead(path))
                {
                    byte[] array = new byte[scanner.Length];
                    scanner.Read(array, 0, array.Length);
                    string textFromFile = System.Text.Encoding.Default.GetString(array);
                    string writer = "";
                    string[] linesFromFile = textFromFile.Split('\n');
                    for (int i = 0; i < linesFromFile.Length; i++)
                    {
                        if (!linesFromFile[i].Contains(Select)) continue;
                        Console.WriteLine(linesFromFile[i]);
                        writer = writer + linesFromFile[i] + "\n";
                        Score++;
                    }
                    File.WriteAllText("result.txt", writer);
                    Console.WriteLine();
                    Console.WriteLine("Done. Total: " + Score);
                    Console.WriteLine("File 'result.txt' is saved!");
                }
            }            
        }
        public static void About()
        {
            Console.Clear();
            Console.WriteLine("We are very important for you, because\n" +
                              "we are created a new MailSorter 0.1v for\n" +
                              "the sort your fucking mails!\n");
            Console.WriteLine("Menu: \n Back\n");
            Console.Write("What do you want: ");

            switch (Console.ReadLine())
            {
                case "Back":
                    Console.Clear();
                    Program.Main();
                    break;
                default:
                    Console.Clear();
                    About();
                    break;
            }
        }        
    }
}
