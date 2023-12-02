using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public static class PlayerExt
    {
        public static void SetPlayerConsole(this Player player) 
        {
            Console.WriteLine($"Please enter {nameof(player)} name");
            player.Name = Console.ReadLine() ?? string.Empty;
        }
    }
}
