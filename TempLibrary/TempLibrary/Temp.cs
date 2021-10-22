using System;

namespace TempLibrary
{
    public class Temp
    {
        public double CTF(double temp)
        {
            double num;
            num = (temp * 9 / 5) + 32;
            return num;

        }
        public double FTC(double temp)
        {
            double var;
            var = (temp - 32) * 5 / 9;
            return var;
        }
    }
}
