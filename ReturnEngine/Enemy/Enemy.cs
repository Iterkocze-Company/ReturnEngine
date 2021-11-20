using System;
using System.Collections.Generic;

namespace ReturnEngine.Enemy
{
    public class Enemy
    {
        private static List<Enemy> Enemies = new List<Enemy>();

        public double HP { get; set; }
        public double AttackPower { get; set; }
        public string Name { get; set; }

        public Enemy(double HP, double AttackPower, string Name)
        {
            this.HP = HP;
            this.Name = Name;
            this.AttackPower = AttackPower;

            Enemies.Add(this);
        }

        public bool Fight(bool ShowStats = true)
        {
            Log.Warn($"You encounter {Name}!\n");
            if (ShowStats)
            {
                Log.Warn($"{Name} has {HP} HP.\n");
                Log.Warn($"{Name} has {AttackPower} Attack power.\n");
            }

            while (HP > 0)
            {
                Console.ReadKey();
                HP -= Player.Stats.AttackPower;
                Vault.HP -= AttackPower;
                if (Vault.HP <= 0)
                {
                    Log.Fail($"{Name} Won the fight.\n");
                    return false;
                }
                Log.Info($"HP: {HP}.\n");
                Log.Info($"Your HP: {Vault.HP}.\n");
            }
            return true;
        }
    }
}
