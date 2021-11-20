using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnEngine
{
    public class Event
    {
        public enum EventYield
        {
            NONE = 0,
            GOLD = 1
        }

        public EventYield yield { get; set; }
        public double yieldAmount { get; set; }
        public double fireOnTurn { get; set; }
        public bool success { get; set; }
        public bool automatic { get; set; }
        public string successMessage { get; set; }
        public string Content { get; set; }

        private string Title;

        public void Fire(string? choice)
        {
            Log.Info(Content+"\n");
            if (Console.ReadLine().Trim() == choice) this.success = true;
            if (!success) Log.Fail($"Event {Title} failed\n");
            if (yield == EventYield.GOLD && success)
            {
                Log.Suc($"{successMessage}\n");
                Vault.Gold += yieldAmount;
            }
        }

        public Event(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
            ReturnEngine.RegisterEvent(this);
            Console.WriteLine("Event object {0} created!", Title);
        }
    }
}
