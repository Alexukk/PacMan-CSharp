using System.Threading;


namespace PacMan
{
    internal class Game
    {
        public static void Start(string map_path)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo key = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
            char[,] map = mapUtils.ReadMap(map_path);
            int lifes = 5;
            int pacx = 1;
            int pacy = 1;
            int score = 0;
            int maxScore = mapUtils.MaxScore(map);

            while (true)
            {
                Console.Clear();

                HandleInput(map, ref pacx, ref pacy, key, ref score, ref lifes);

                if (score == maxScore)
                {
                    GameUtils.ShowWonScreen();
                    break;
                }
                if (lifes <= 0)
                {
                    GameUtils.ShowGameOverScreen();
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                mapUtils.DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacx, pacy);
                Console.Write('@');

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(map.GetLength(0) + 5, 2);
                Console.Write($"Score: {score}");

                Console.SetCursorPosition(map.GetLength(0) + 5, 3);
                ShowLifes(ref lifes);
                Console.ForegroundColor = ConsoleColor.Red;
                key = Console.ReadKey(true);
                Console.SetCursorPosition(map.GetLength(0) + 5, 5);
            }
        }

        private static void HandleInput(char[,] map, ref int pacx, ref int pacy, ConsoleKeyInfo key, ref int score, ref int lifes)
        {
            int newX = pacx;
            int newY = pacy;

            if (key.Key == ConsoleKey.UpArrow) newY--;
            else if (key.Key == ConsoleKey.DownArrow) newY++;
            else if (key.Key == ConsoleKey.LeftArrow) newX--;
            else if (key.Key == ConsoleKey.RightArrow) newX++;

            if (newX >= 0 && newX < map.GetLength(0) &&
                newY >= 0 && newY < map.GetLength(1) &&
                map[newX, newY] != '#')
            {
 
                if (map[newX, newY] == '.')
                {
                    score++;
                    map[newX, newY] = ' ';
                }

                pacx = newX;
                pacy = newY;
            } else
            {
                lifes--;
            }
        }

        private static void ShowLifes(ref int lifes)
        {
            Console.Write("Lifes Left:");
            for (int i = 0; i < lifes; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                Console.ResetColor();
            }
        }


    }
}

