using System;
using System.IO;
using System.Linq;

namespace PacMan
{
    internal class mapUtils
    {
        public static char[,] ReadMap(string filePath)
        {
            string[] file = File.ReadAllLines(filePath);

            int width = file.Max(line => line.Length);
            int height = file.Length;

            char[,] map = new char[width, height];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x < file[y].Length)
                        map[x, y] = file[y][x];
                    else
                        map[x, y] = ' ';
                }
            }

            return map;
        }

        public static void DrawMap(char[,] map)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (map[x, y] == '#')
                        Console.ForegroundColor = ConsoleColor.Blue;
                    else if (map[x, y] == '.')
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ResetColor();
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }


        public static int MaxScore(char[,] map)
        {
            int score = 0;

            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (map[x, y] == '.')
                        score++;
                }
            }

            return score;
        }

    }
}