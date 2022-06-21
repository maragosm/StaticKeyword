using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public static class TempConverter
    {
        public static double TempFtoC(double fTemp)
        {
            return (fTemp - 32) / 1.8;
        }
        public static double TempCtoF(double cTemp)
        {
            return (cTemp * 9) / 5 + 32;
        }
    }
}
