using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udoma
{
    public class WorldState
    {
        public int numberOfTimesWalked = 0; // member variable

        public bool IsWin() // "member function" a.k.a "method"
        {
            return numberOfTimesWalked >= 4;
        }
    }
}
