using System;

namespace DungeonGame
{
    internal class Enemy
    {
        private int enemyHealth;
        private char enemyType;
        private int enemyExpReward;

        public Enemy(int enemyHealth, char enemyType, int enemyExpReward)
        {
            this.enemyHealth = enemyHealth;
            this.enemyType = enemyType;
            this.enemyExpReward = enemyExpReward;
        }

        public int GetHealth()
        {
            return enemyHealth;
        }

        public void SetHealth(int health)
        {
            enemyHealth = health;
        }

        public void DecrementHealth(int health)
        {
            enemyHealth -= health;
        }

        public int GetEnemyExpReward()
        {
            return enemyExpReward;
        }
    }
}
