using System;
using System.Collections.Generic;
using System.Text;


namespace MyCalcDemo
{
    public static class MyMath
    {
        public static void Main(string[] args)
        {

        }

        public static bool isLeapYear(int Year)
        {
            if (Year % 400 == 0) return true;
            if (Year % 100 == 0) return false;
            if (Year % 4 == 0) return true;
            return false;
        }

        public static int FindStringLength(string input)
        {
            return input?.Length ?? 0;
        }
    }
}