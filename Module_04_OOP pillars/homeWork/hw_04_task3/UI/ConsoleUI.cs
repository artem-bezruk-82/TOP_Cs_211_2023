using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI
{
    public class ConsoleUI : IView
    {
        private bool _isWorking;

        public ConsoleUI()
        {
            _isWorking = true;
        }

        public void End()
        {
            _isWorking = false;
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Start()
        {
            Menu.Menu menu = new Menu.Menu("Main menu\n");
            menu.Add(new Menu.Commands.Exit(this));
            menu.Add(new Menu.Commands.Encode(this));
            menu.Add(new Menu.Commands.Decode(this));

            while (_isWorking)
            {
                int menuItemIndex = GetConsoleInputInt(menu.ToString() ,0, menu.Size - 1);
                menu.Execute(menuItemIndex);
            }
        }

        public void Encode() 
        {
            CoDecs.CoDecMorze codecMorze = new CoDecs.CoDecMorze();
            string encodedText = codecMorze.GetEncodedText(GetUserInputConsole("Please enter plain text"));
            Console.WriteLine(encodedText);
        }

        public void Decode()
        {
            CoDecs.CoDecMorze codecMorze = new CoDecs.CoDecMorze();
            string decodedText = codecMorze.GetDecodedText(GetUserInputConsole("Please enter encoded text"));
            Console.WriteLine(decodedText);
        }

        static int GetConsoleInputInt(string requestText, int startRange, int endRange)
        {
            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? string.Empty);
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} value");
                }
                if (value < startRange || value > endRange) 
                {
                    Console.WriteLine($"value {value} is out of {startRange}...{endRange} values");
                    value = null;
                }
            }
            return (int)value;
        }

        public string GetUserInputConsole(string requestText) 
        {
            Console.WriteLine($"{requestText} (Ctrl+Z to finish entering data)");
            string text = Console.In.ReadToEnd();
            text = text.Replace("\r\n", string.Empty);
            return text;
        }

    }
}
