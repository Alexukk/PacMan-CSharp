using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal class menu
    {
        public static void ShowOptions(string[] mapsPath)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option (1-2): ");
                var choice = Console.ReadKey(true);
                Console.Clear();
                try
                {
                    int answer = int.Parse(choice.KeyChar.ToString());
                    switch(answer){
                        case 1:
                            ShowMapMenu(mapsPath);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;

                    } 
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter a valid option.");
                    continue;
                }
            }

        }

        public static void StartText()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("          WELCOME TO PACMAN          ");
            Console.WriteLine("=====================================");
        }

        public static void ShowMapMenu(string[] mapsPath)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("All MAPS");
            Console.WriteLine("=====================================");
            Console.WriteLine();
            foreach (var map in mapsPath) {
                Console.WriteLine($"{mapsPath.ToList().IndexOf(map) +1}. {map}");
            }
            Console.Write("Select a map by entering its number: ");
            var choice = Console.ReadKey(true);
            try
            {
                int answer = int.Parse(choice.KeyChar.ToString());
                if (answer >= 1 && answer <= mapsPath.Length)
                {
                    Game.Start(mapsPath[answer - 1] + ".txt");
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter a valid option.");
            }

        }

    }
}
