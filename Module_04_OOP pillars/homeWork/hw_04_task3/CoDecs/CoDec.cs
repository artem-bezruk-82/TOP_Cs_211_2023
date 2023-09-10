using hw_04_task3.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.CoDecs
{
    public abstract class CoDec : IDecodable, IEncodable
    {
        protected ICode _code;

        public CoDec(ICode code)
        {
            _code = code;
        }

        public abstract string GetDecodedText(string encodedText);
        public abstract string GetEncodedText(string plainText);
    }
}
