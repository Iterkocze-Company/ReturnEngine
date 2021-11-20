using System;
using ReturnEngine;

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
        }

        public override void OnTurn()
        {
            Vault.Gold++;
        }
    }
}
