using System;
using System.Collections;

namespace DungeonGame
{
    internal class Game
    {
        private readonly Player P1;
        private readonly Room[,] DungeonRooms;

        public Game(int DungeonSize)
        {
            P1 = new(10, 100);
            DungeonRooms = new Room[DungeonSize, DungeonSize];
        }

        public void StartGame()
        {
            InstantiateRooms();
            P1.SetCoords(0, ((DungeonRooms.GetLength(1)/2) - 1));
            PrintPos();
            CheckForMonsterAndFight();
        }

        private void PrintPos()
        {
            Console.WriteLine("The player is in position " + P1.GetYCoord() + ", " + P1.GetXCoord());
        }

        private void InstantiateRooms()
        {
            for (int y = 0; y < DungeonRooms.GetLength(0); y++)
            {
                for (int x = 0; x < DungeonRooms.GetLength(1); x++)
                {
                    DungeonRooms[y, x] = new Room();
                }
            }
        }

        private void InstantiateEnemies()
        {
            ArrayList toGenMonstersY = new ArrayList();
            ArrayList toGenMonstersX = new ArrayList();
            Random rand = new Random();
            int randomCoord;
            for (int y = 0; y < (DungeonRooms.GetLength(0)); y++)
            {
                randomCoord = rand.Next();
                toGenMonstersY.Add(randomCoord);
            }
            for (int x = 0; x < (DungeonRooms.GetLength(1)); x++)
            {
                randomCoord = rand.Next();
                toGenMonstersX.Add(randomCoord);
            }
            int numToGen;
            if (toGenMonstersY.Count > toGenMonstersX.Count)
            {
                numToGen = toGenMonstersX.Count;
            }
            else
            {
                numToGen = toGenMonstersY.Count;
            }
            for (int i = 0; i < numToGen; i++)
            {
                if (DungeonRooms[(int)toGenMonstersY[i], (int)toGenMonstersX[i]].IsEnemyPresent() == false) {
                DungeonRooms[(int)toGenMonstersY[i], (int)toGenMonstersX[i]].SetEnemy(new Enemy(1, 'w', 100));
            }
            }
        }

        private void CheckForMonsterAndFight()
        {
            if (DungeonRooms[P1.GetXCoord(), P1.GetYCoord()].IsEnemyPresent())
            {
                Console.WriteLine("A monster approaches!");
                Console.WriteLine("You hit the enemy");
                DungeonRooms[P1.GetXCoord(), P1.GetYCoord()].GetEnemy().DecrementHealth(1);
                if(DungeonRooms[P1.GetXCoord(), P1.GetYCoord()].EnemyDefeated())
                {
                    Console.WriteLine("You defeated the enemy!");
                    P1.LevelUp(DungeonRooms[P1.GetXCoord(), P1.GetYCoord()].GetEnemy().GetEnemyExpReward());
                };
            }
        }
    }
}
