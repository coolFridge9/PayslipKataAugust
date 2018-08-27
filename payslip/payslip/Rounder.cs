using System;

namespace payslip
{
    public class Rounder
    {
        public static int Round(double num)
        {
            return Convert.ToInt32(Math.Round(num, MidpointRounding.AwayFromZero));
        }
    }
}