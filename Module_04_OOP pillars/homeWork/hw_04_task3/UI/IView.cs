using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.UI
{
    public interface IView
    {
        void Print(string text);
        void Start();
        void End();
    }
}
