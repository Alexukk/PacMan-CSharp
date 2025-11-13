namespace PacMan
{
    internal class Game
    {
        public static void Start(string map_path)
        {
            char[,] map = null;
            map = mapUtils.ReadMap(map_path);
            Console.WriteLine(map);
            Console.ReadKey();

        }
    }
}

