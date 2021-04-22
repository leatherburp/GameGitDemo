using System;
using static System.Console;
namespace GameGitDemo
{
    public class Game
    {
        public void Run()
        {
            WriteLine("=== Welcome to the game ===");

            Write("\nWhat is your name? ");
            string name = ReadLine();
            Player currentPlayer = new Player(name);

            WriteLine($"Let's get started {currentPlayer.Name}!");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
