using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Tas2
{
    public static class ParseNumber
    {
        public static int Parse(string number)
        {
            int result = 0;
            int counter = 1;
            for (int i = number.Length-1; i >=0 ; i--)
            {
                result = result + ToDigit(number[i])*counter;
                counter *= 10;
            }
            return result;
        }

        private static int ToDigit(char a)
        {
            int b = Convert.ToByte(a);
            return b - 48;
        }
    }
}
