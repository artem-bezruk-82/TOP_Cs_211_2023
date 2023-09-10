using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_04_task3.Codes
{
    public class MorzeCode : ICode
    {
        private Dictionary<char, string> codeDictionary = new Dictionary<char, string>()
            {
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
                {'.', "......"},
                {',', ".-.-.-"},
                {':', "---..."},
                {';', "-.-.-."},
                {'?', "..--.."},
                {'!', "--..--"},
                {'/', "-..-."},
                {'-', "-....-"},
                {'a',".-"},
                {'b',"-..."},
                {'c',"-.-."},
                {'d',"-.."},
                {'e',"."},
                {'f',"..-."},
                {'g',"--."},
                {'h',"...."},
                {'i',".."},
                {'j',".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-.--"},
                {'z',"--.."},
            };

        public string? GetCode(char symbol)
        {
            return codeDictionary.ContainsKey(symbol) ? codeDictionary[symbol] : null;
        }

        public char? GetSymbol(string code)
        {
            foreach (KeyValuePair<char, string> record in codeDictionary)
            {
                if (record.Value == code)
                    return record.Key;
            }
            return null;
        }
    }
}
