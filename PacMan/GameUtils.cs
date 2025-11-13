using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal class GameUtils
    {
        public static void EndScreen()
        {
            string[] victoryArt = new string[]
{
    "................................................",
    ".     YY   YY   OOOOO   U   U       W   W   OOOOO   N   N   !!!   ",
    ".      YY YY   O     O  U   U       W   W  O     O  NN  N   !!!   ",
    ".       YYY    O     O  U   U       W W W  O     O  N N N   !!!   ",
    ".       YYY    O     O  U   U       WW WW  O     O  N  NN   !!!   ",
    ".       YYY    O     O  U   U       W   W  O     O  N   N         ",
    ".       YYY     OOOOO    UUU        W   W   OOOOO   N   N   !!!   ",
    "................................................",
    "",
    "         CONGRATULATIONS! YOU WON THE LEVEL!",
    "         PRESS ANY KEY TO RETURN TO MENU..."
};

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string line in victoryArt)
            {
                Console.WriteLine(line);
            }

            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}
