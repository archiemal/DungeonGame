using System;

namespace DungeonGame
{
    internal class Player
    {
        private int max_health;
        private int current_health;
        private int level = 1;
        private int expForLevelUp;
        private int currentExp = 0;
        private int xCoord;
        private int yCoord;

        public Player(int max_health, int expForLevelUp)
        {
            this.max_health = max_health;
            current_health = this.max_health;
            this.expForLevelUp = expForLevelUp;
        }

        public void SetCoords(int yCoord, int xCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public int GetXCoord() { return xCoord; }

        public int GetYCoord() { return yCoord; }

        public void LevelUp(int expPoints)
        {
            currentExp += expPoints;
            if (currentExp >= expForLevelUp)
            {
                currentExp -= expForLevelUp;
                level += 1;
                Console.WriteLine("You levelled up!");
            }
        }
    }
}
