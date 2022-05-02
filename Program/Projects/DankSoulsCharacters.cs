using System;

namespace Program.Projects
{
    internal class DankSoulsCharacters
    {
        public string Name { get; }
        public int Health { get; set; }
        private int Stamina { get; set; }
        private int StrengthMax { get; }
        private int StrengthMin { get; }
        private int MaxStamina { get; }

        public DankSoulsCharacters(string name, int health, int strengthMin, int strengthMax, int stamina)
        {

            Name = name;
            Health = health;
            Stamina = stamina;
            StrengthMax = strengthMax;
            StrengthMin = strengthMin;
            MaxStamina = stamina;
        }

        public void Fight(DankSoulsCharacters target)
        {
            if (Stamina == 0)
            {
                Recharge();
                Console.WriteLine("-" + Name + " Used stamina potion" + "-" + "\n");
            }
            else
            {
                var random = new Random();
                var damage = random.Next(StrengthMin, StrengthMax + 1);

                target.TakeDamage(damage);
                Stamina -= 10;
                Console.WriteLine("-" + Name + " hits " + "for " + damage + " dmg, " + target.Name + " HP : " + target.Health + "\n");
            }
        }

        private void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        private void Recharge()
        {
            Stamina = MaxStamina;
        }


    }
}
