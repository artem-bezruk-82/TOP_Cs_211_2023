using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.Codes
{
    public interface ICode
    {
        string? GetCode(char symbol);

        char? GetSymbol(string code);
    }
}
