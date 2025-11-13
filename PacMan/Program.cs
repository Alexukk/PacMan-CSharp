using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mapsPath = ["map", "simple", "medium", "hard", "crazy"];

            menu.StartText();
            menu.ShowOptions(mapsPath);

        }
    }
}