using System;
using System.IO;
using System.Security;
using MuratShell.Utils;

namespace MuratShell
{
    class Program
    {

        private static bool isRunning = true;
        private static string username = Environment.UserName;
        private static string machinename = Environment.MachineName;
        private static Help[] helplist;

        static void Main(string[] args)
        {
            pre_init();
            init();
        }

        static void pre_init()
        {
            Console.WriteLine("MuratShell [Version 1.0]");
            Console.WriteLine("(c) 2021 MuratDeveloper. Tüm haklar saklıdır");
        }
        
        static void init()
        {
            while (isRunning)
            {
                Console.WriteLine(" ");
                Console.Write(Directory.GetCurrentDirectory()+">");
                Console.ForegroundColor = ConsoleColor.;
                String input = Console.ReadLine();
                Console.ResetColor();
                String[] args = input.Split(" ");

                switch (args[0])
                {

                    case "rect":
                        if (args.Length >= 3)
                        {
                            new Komutlar.Rect(args);
                            break;
                        }
                        new Komutlar.Rect();
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "tetris":
                        new Komutlar.Tetris();
                        break;

                    case "helloworld":
                        Console.WriteLine("Hello, World!");
                        break;

                    case "help":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Commands");
                        Console.WriteLine("====================");
                        //foreach (Help helper in helplist) {
                        //    Console.WriteLine(Help.getCommandName()+","+Help.getHelpString());
                        //}
                        new Komutlar.Help();
                        Console.ResetColor();
                        break;

                    case "neofetch":
                        //Console.BackgroundColor = ConsoleColor.Blue;
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.WriteLine("White on blue.");
                        //Console.WriteLine("Another line.");
                        //Console.ResetColor();
                        new Komutlar.Neofetch();
                        
                        break;

                    case "exit":
                        isRunning = false;
                        break;

                    default:
                        if (args[0] == "")
                        {
                            break;
                        }
                        Console.WriteLine("`"+ args[0] +"` is not recognized as an internal or external command,");
                        Console.WriteLine("operable program or batch file.");
                        break;
                }
            }
        }
    }
}
