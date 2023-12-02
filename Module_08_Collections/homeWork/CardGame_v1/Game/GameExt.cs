using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public static class GameExt
    {
        public static void GameMenu(this Game game)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>()
            {
                { 0, "Exit"},
                { 1, "Start game"},
                { 2, "Add player"},
            };

            int menuItem = -1;

            while (menuItem != 0)
            {
                Console.WriteLine("Game menu");

                foreach (KeyValuePair<int, string> item in menu)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value}");
                }

                menuItem = (int)GetConsoleInputInt("Please chose menu item", 0, menu.Count);

                switch (menuItem)
                {
                    case 1:
                        PlayGame(game);
                        break;
                    case 2:
                        AddPlayerConsole(game);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void AddPlayerConsole(this Game game) 
        {
            Player player = new Player("Player");
            PlayerExt.SetPlayerConsole(player);
            try
            {
                game.AddPlayer(player);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private static void PlayGame(this Game game) 
        {
            try
            {
                game.SetupGame();
                while (game.PlayersCount > 1)
                {
                    game.PlayRound();
                    Console.WriteLine(game);
                }
                Console.WriteLine($"Game over won!");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private static int GetConsoleInputInt(string requestText, int startRange = int.MinValue, 
            int endRange = int.MaxValue)
        {
            int? value = null;

            do
            {
                while (value is null)
                {
                    Console.WriteLine(requestText);
                    try
                    {
                        value = int.Parse(Console.ReadLine() ?? "");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine($"{exc.Message} Please enter integer value");
                    }
                }
                if (value < startRange || value > endRange)
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        message: $"value is out of {startRange}...{endRange} value");
            } while (value < startRange || value > endRange);

            return (int)value;
        }
    }
}
