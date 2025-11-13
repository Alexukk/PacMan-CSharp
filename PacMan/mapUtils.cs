using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PacMan
{
    internal class mapUtils
    {




        public static char[,] ReadMap(string filePath)
        {
            string[] file = File.ReadAllLines(filePath);

            char[,] map = new char[maxLengthOfLine(file), file.Length];

            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (x < file[y].Length)
                        map[x, y] = file[y][x];
                    else
                        map[x, y] = ' '; // или другой символ-заполнитель
                }
            }
            return map;


        }

        private static int maxLengthOfLine(string[] lines)
        { 
            int maxLength = lines[0].Length;

            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            return maxLength;
        }

        public static void DrawMap(char[,] map)
        {

        }

    }
}
