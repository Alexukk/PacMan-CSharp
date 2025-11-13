namespace PacMan
{
    internal class Game
    {
        public static void Start(string map_path)
        {
            Console.CursorVisible = false;
            ConsoleKeyInfo key = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
            char[,] map = null;
            map = mapUtils.ReadMap(map_path);

            int pacx = 1;
            int pacy = 1;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                mapUtils.DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacx, pacy);
                Console.Write('@');

                Console.ForegroundColor = ConsoleColor.Red;
                key = Console.ReadKey(true);
                HandleInput(map, ref pacx, ref pacy, key);

                Console.SetCursorPosition(34, 1);
                Console.Write(key.KeyChar);
            }

        }

        private static void HandleInput(char[,] map, ref int pacx, ref int pacy, ConsoleKeyInfo key)
        {

            if (key.Key == ConsoleKey.UpArrow)
            {
                pacy--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                pacy++;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                pacx--;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                pacx++;
            }


        }
    }
}

