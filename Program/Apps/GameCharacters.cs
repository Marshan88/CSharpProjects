using System;

namespace Program.Apps
{
    internal class GameCharacter
    {
        public string Name;
        public int Health;
        public int Stamina;
        public int StrengthMax;
        public int StrengthMin;
        private readonly int _maxStamina;
        public GameCharacter()
        {
            Stamina = 10;
            StrengthMax = 10;
            StrengthMin = 10;
            _maxStamina = Stamina;
        }

        public GameCharacter(string name, int health, int strengthMin, int strengthMax, int stamina)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
            StrengthMax = strengthMax;
            StrengthMin = strengthMin;
            _maxStamina = stamina;
        }

        public void Fight(GameCharacter target)
        {
            if (Stamina == 0)
            {
                Recharge();
                Console.WriteLine("-" + Name + " Used stamina potion" + "-" + "\n");
            }
            else
            {
                Random random = new Random();
                int damage = random.Next(StrengthMin, StrengthMax + 1);

                target.TakeDamage(damage);
                Stamina -= 10;
                Console.WriteLine("-" + Name + " hits " + "for " + damage + " dmg, " + target.Name + " HP : " + target.Health + "\n");
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Recharge()
        {
            Stamina = _maxStamina;
        }
    }
}
