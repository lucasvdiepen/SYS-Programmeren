using System;

namespace InheritanceDeel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 30);

            Money money = new Money(10);
            money.OnPickup(player);

            HealPotion healPotion = new HealPotion(30);
            healPotion.OnPickup(player);

            ManaPotion manaPotion = new ManaPotion(5);
            manaPotion.OnPickup(player);

            Console.WriteLine("Player money: " + player.money);
            Console.WriteLine("Player health: " + player.health);
            Console.WriteLine("Player mana: " + player.mana);
        }

        public class Player
        {
            private int startingHealth;

            public int money = 0;
            public int health = 0;
            public int mana = 0;

            public Player(int startingHealth, int startingMana)
            {
                this.startingHealth = startingHealth;
                health = startingHealth;
                mana = startingMana;
            }

            public void AddMoney(int amount)
            {
                money += amount;
            }

            public void AddHealth(int amount)
            {
                health += amount;
                if (health > startingHealth) health = startingHealth;
            }

            public void AddMana(int amount)
            {
                mana += amount;
            }
        }

        public abstract class Equipment
        {
            public virtual void Equip()
            {
                Console.WriteLine("Item equipped");
            }
        }

        public abstract class Pickup
        {
            public abstract void OnPickup(Player player);

            public virtual void HitByMouse(float x, float y)
            {

            }
        }

        public class Armor : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Weapon : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Money : Pickup
        {
            public int money;

            public Money(int money)
            {
                this.money = money;
            }

            public override void OnPickup(Player player)
            {
                player.AddMoney(money);
            }
        }

        public class HealPotion : Pickup
        {
            public int heal;

            public HealPotion(int heal)
            {
                this.heal = heal;
            }

            public override void OnPickup(Player player)
            {
                player.AddHealth(heal);
            }
        }

        public class ManaPotion : Pickup
        {
            public int mana;

            public ManaPotion(int mana)
            {
                this.mana = mana;
            }

            public override void OnPickup(Player player)
            {
                player.AddMana(mana);
            }
        }
    }
}
