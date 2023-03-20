using System;

namespace DungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game CurrentGame = new Game(10);
            CurrentGame.StartGame();
        }
    }
}