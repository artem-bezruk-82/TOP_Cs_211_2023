using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw_04_task3.UI.Menu
{
    public class Menu
    {
        private List<Commands.Command> commands;
        private string title;
        public int Size { get { return commands.Count; } }

        public Menu(string title, List<Commands.Command> commands)
        {
            this.title = title;
            this.commands = commands;
        }

        public Menu(string title) : this(title, new List<Commands.Command>()) { }

        public bool Add(Commands.Command command)
        {
            if (!commands.Contains(command))
            {
                commands.Add(command);
                return true;
            }
            return false;
        }

        public void Execute(int menuItem)
        {
            commands[menuItem].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(title);
            for (int i = 0; i < commands.Count; i++)
            {
                sb.Append($"{i} - {commands[i].Description}\n");
            }
            return sb.ToString();
        }
    }
}
