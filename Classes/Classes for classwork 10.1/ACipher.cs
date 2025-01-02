using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_classwork_10._1
{
    public class ACipher : ICipher
    {
        public string Encode(string input) => Shift(input, 1);
        public string Decode(string input) => Shift(input, -1);

        private string Shift(string input, int offset)
        {
            StringBuilder result = new StringBuilder(input.Length);

            foreach (char ch in input)
            {
                result.Append(CipherUtils.ShiftCharacter(ch, offset));
            }

            return result.ToString();
        }
    }
}
