using System;
using static System.Console;
namespace GameGitDemo
{
    public class Game
    {
        public void Run()
        {
            WriteLine("=== Welcome to the game ===");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
