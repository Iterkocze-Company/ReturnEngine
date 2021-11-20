using System;
using ReturnEngine;
using ReturnEngine.Enemy;
using ReturnEngine.Player;

namespace ReturnEngineDemoGame
{
    public static class StartUp
    {
        private static void Main()
        {
            _ = new DemoGame();
        }
    }

    class DemoGame : ReturnEngine.ReturnEngine
    {
        public DemoGame() : base("RETURN ENGINE DEMO")
        {

        }

        public override void OnLoad()
        {
            Stats.AttackPower = 2;

            Event e = new("Hello", "Type 'yes' to get 5 gold.");
            e.yield = Event.EventYield.GOLD;
            e.successMessage = "You got 5 gold!";
            e.yieldAmount = 5;
            e.Fire("yes");

            Event x = new("Gold", "Someone gave you 10 gold!");
            x.fireOnTurn = 3;
            x.yield = Event.EventYield.GOLD;
            x.yieldAmount = 10;
            x.success = true;
            x.automatic = true;
            x.successMessage = "You got 10 gold.";

            Enemy enemy = new(10, 30, "Zombie");
            if (enemy.Fight() == false)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("You ded.");
                    Console.ReadKey();
                }
            }
        }

        public override void OnTurn()
        {
            Vault.Gold++;
            if (Vault.HP < 100) Vault.HP++;
        }
    }
}
