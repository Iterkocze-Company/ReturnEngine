using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace ReturnEngine
{
    public abstract class ReturnEngine
    {
        private readonly string Title = "New RETURNENGINE Game";

        private static List<Event> Events = new List<Event>();

        public ReturnEngine(string Title)
        {
            Console.Title = Title;
            GameLoop();
        }

        public static void RegisterEvent(Event element)
        {
            Events.Add(element);
        }

        void GameLoop()
        {
            OnLoad();

            while (true)
            {
                OnTurn();
                foreach (Event e in Events)
                {
                    if (e.fireOnTurn == Turn.turn && e.automatic) 
                    {
                        e.Fire(null);
                    }
                }
                Turn.turn++;
                Status.Show();
                Console.ReadKey();
            }
        }

        public abstract void OnLoad();
        public abstract void OnTurn();
    }
}
