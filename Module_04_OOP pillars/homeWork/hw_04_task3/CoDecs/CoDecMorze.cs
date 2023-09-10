using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.CoDecs
{
    public class CoDecMorze : CoDec
    {
        public CoDecMorze() : base(new Codes.MorzeCode()) { }

        public override string GetDecodedText(string encodedText)
        {
            StringBuilder decodedTextSB = new StringBuilder();
            string[] encodedTextWords = encodedText.Split("\n");

            foreach (string encodedWord in encodedTextWords) 
            {
                string[] codes = encodedWord.Split(" ");
                foreach (string code in codes) 
                {
                    char? symbol = _code.GetSymbol(code);
                    decodedTextSB.Append(symbol);
                }
                decodedTextSB.Append(" ");
            }

            return decodedTextSB.ToString();
        }

        public override string GetEncodedText(string plainText)
        {
            string[] plainTextWords = plainText.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder encodedTextSB = new StringBuilder();

            foreach (string word in plainTextWords) 
            {
                char[] symbols = word.ToCharArray();
                for (int i = 0; i < symbols.Length; i++)
                {
                    string? code = _code.GetCode(symbols[i]);
                    encodedTextSB.Append((code == null) ? "######" : code);
                    encodedTextSB.Append(" ");
                }
                encodedTextSB.Append("\n");
            }
            return encodedTextSB.ToString();
        }
    }
}
