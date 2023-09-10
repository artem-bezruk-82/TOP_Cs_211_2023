using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI.Menu.Commands
{
    public abstract class Command
    {
        protected IView view;

        public string Description { get; private set; }

        public Command(IView view, string description)
        {
            this.view = view;
            Description = description;
        }

        public abstract void Execute();
    }
}
