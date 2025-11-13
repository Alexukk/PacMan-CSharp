using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal class GameUtils
    {
        public static void ShowWonScreen()
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


        public static void ShowGameOverScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            string[] gameOverArt = new string[]
            {
        "########################################",
        "#                                      #",
        "#   GGGG   AAAAA  M   M  EEEEE         #",
        "#  G       A   A  MM MM  E             #",
        "#  G  GG   AAAAA  M M M  EEEE          #",
        "#  G   G   A   A  M   M  E             #",
        "#   GGGG   A   A  M   M  EEEEE         #",
        "#                                      #",
        "#   OOOOO  V   V  EEEEE  RRRR          #",
        "#  O     O V   V  E      R   R         #",
        "#  O     O V   V  EEEE   RRRR          #",
        "#  O     O  V V   E      R R           #",
        "#   OOOOO    V    EEEEE  R  RR         #",
        "#                                      #",
        "########################################",
        "",
        "       YOU LOST! BETTER LUCK NEXT TIME!",
        "       PRESS ANY KEY TO RETURN TO MENU..."
            };

            foreach (string line in gameOverArt)
            {
                Console.WriteLine(line);
            }

            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}
