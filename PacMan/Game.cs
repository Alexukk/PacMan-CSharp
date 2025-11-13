namespace PacMan
{
    internal class Game
    {
        public static void Start(string map_path)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo key = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
            char[,] map = mapUtils.ReadMap(map_path);

            int pacx = 1;
            int pacy = 1;
            int score = 0;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                mapUtils.DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacx, pacy);
                Console.Write('@');

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(map.GetLength(0) + 5, 2);
                Console.Write($"Score: {score}");

                Console.ForegroundColor = ConsoleColor.Red;
                key = Console.ReadKey(true);
                HandleInput(map, ref pacx, ref pacy, key, ref score);

                Console.SetCursorPosition(map.GetLength(0) + 5, 4);
                Console.Write($"Last key: {key.KeyChar}");
            }
        }

        private static void HandleInput(char[,] map, ref int pacx, ref int pacy, ConsoleKeyInfo key, ref int score)
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
            }
        }

    }
}

