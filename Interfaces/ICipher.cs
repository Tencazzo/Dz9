using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9.Interfaces
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}
