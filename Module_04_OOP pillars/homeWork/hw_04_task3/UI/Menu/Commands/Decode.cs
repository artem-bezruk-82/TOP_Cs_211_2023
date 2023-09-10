using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI.Menu.Commands
{
    public class Decode : Command
    {
        public Decode(ConsoleUI consoleUI) : base(consoleUI, "Decode text") { }

        public override void Execute()
        {
            ((ConsoleUI)view).Decode();
        }
    }
}
