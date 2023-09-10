using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI.Menu.Commands
{
    internal class Encode : Command
    {
        public Encode(ConsoleUI consoleUI) : base(consoleUI, "Encode plain text") { }

        public override void Execute()
        {
            ((ConsoleUI)view).Encode();
        }
    }
}
