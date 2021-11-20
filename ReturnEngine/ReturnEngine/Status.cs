using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnEngine
{
    public static class Status
    {
        public static void Show()
        {
            Log.Info($"Gold: {Vault.Gold}");
            Log.Info($"\tYour HP: {Vault.HP}");
            Log.Info($"\tTurn: {Turn.turn}");
        }
    }
}
