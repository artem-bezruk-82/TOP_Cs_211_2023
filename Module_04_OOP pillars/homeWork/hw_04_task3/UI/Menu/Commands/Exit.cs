using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI.Menu.Commands
{
    public class Exit : Command
    {
        public Exit(ConsoleUI consoleUI) : base(consoleUI, "Exit") { }

        public override void Execute()
        {
            view.End();
        }
    }
}
