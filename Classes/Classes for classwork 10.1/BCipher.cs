using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_classwork_10._1
{
    public class BCipher : ICipher
    {
        public string Encode(string input) => Reflect(input);
        public string Decode(string input) => Reflect(input);

        private string Reflect(string input)
        {
            StringBuilder result = new StringBuilder(input.Length);

            foreach (char ch in input)
            {
                result.Append(CipherUtils.ReflectCharacter(ch));
            }

            return result.ToString();
        }
    }
}
