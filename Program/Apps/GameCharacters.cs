using System;

namespace Program.Apps
{
    internal class GameCharacter
    {
        public readonly string Name;
        public int Health;
        private int _stamina;
        private readonly int _strengthMax;
        private readonly int _strengthMin;
        private readonly int _maxStamina;
        //public GameCharacter()
        //{
        //    _stamina = 10;
        //    _strengthMax = 10;
        //    _strengthMin = 10;
        //    _maxStamina = _stamina;
        //}

        public GameCharacter(string name, int health, int strengthMin, int strengthMax, int stamina)
        {
            Name = name;
            Health = health;
            _stamina = stamina;
            _strengthMax = strengthMax;
            _strengthMin = strengthMin;
            _maxStamina = stamina;
        }

        public void Fight(GameCharacter target)
        {
            if (_stamina == 0)
            {
                Recharge();
                Console.WriteLine("-" + Name + " Used stamina potion" + "-" + "\n");
            }
            else
            {
                var random = new Random();
                var damage = random.Next(_strengthMin, _strengthMax + 1);

                target.TakeDamage(damage);
                _stamina -= 10;
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
            _stamina = _maxStamina;
        }
    }
}
