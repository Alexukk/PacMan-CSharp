using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mapsPath = ["simple", "medium", "hard", "crazy", "secret"];

            menu.StartText();
            menu.ShowOptions(mapsPath);

        }
    }
}