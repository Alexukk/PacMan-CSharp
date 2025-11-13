namespace PacMan
{
    internal class Game
    {
        public static void Start(string map_path)
        {
            char[,] map = null;
            map = mapUtils.ReadMap(map_path);
            mapUtils.DrawMap(map);
             
            while (true)
            {
                Console.SetCursorPosition(1, 1);
                Console.WriteLine('@');

                Thread.Sleep(500);
            }

        }
    }
}

