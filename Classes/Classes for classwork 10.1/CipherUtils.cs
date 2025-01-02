using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Classes.Classes_for_classwork_10._1
{
    public static class CipherUtils
    {
        public static char ShiftCharacter(char ch, int offset)
        {
            if (char.IsLetter(ch))
            {
                char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((((ch - baseChar + offset) + 26) % 26) + baseChar);
            }
            return ch;
        }

        public static char ReflectCharacter(char ch)
        {
            if (char.IsLetter(ch))
            {
                char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                return (char)('Z' - (ch - baseChar));
            }
            return ch;
        }
    }
}
