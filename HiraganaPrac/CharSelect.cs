using System;
using System.Collections.Generic;
using System.Text;

namespace HiraganaPrac
{
    class CharSelect
    {
        public static int RanSelect(int min, int max)
        {
            var r = new Random();
            return r.Next(min, max);
        }
    }
}
