using System;


namespace DungeonGame
{
    internal class Room
    {
        private Enemy? E1;
        public Room()
        {
        }

        public bool IsEnemyPresent()
        {
            return (E1 != null);
        }

        public Enemy GetEnemy()
        {
            return E1;
        }

        public void SetEnemy(Enemy e1)
        {
            E1 = e1;
        }

        public bool EnemyDefeated()
        {
            if (E1.GetHealth() <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
