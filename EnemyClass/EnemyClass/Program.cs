using System;
using System.Threading;

namespace EnemyClass
{
    class Program
    {
        private class Enemy
        {
            public int health { get; private set; }

            public Enemy(int _health)
            {
                health = _health;
            }

            public void TakeDamage(int damage)
            {
                if(health > 0)
                {
                    health -= damage;
                    if (health <= 0) Console.WriteLine("Enemy died");
                }
            }
        }

        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(100);

            Random rnd = new Random();

            while (true)
            {
                enemy.TakeDamage(rnd.Next(5, 20));

                Console.WriteLine("Enemy health: " + enemy.health);

                if (enemy.health <= 0) break;

                Thread.Sleep(1000);
            }
        }
    }
}
