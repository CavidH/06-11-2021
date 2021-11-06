using System;
 

namespace _06._11._2021L
{
    public class Calculator
    {
        public static int Topla(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Topla(params int[] nummbers)
        {
            int Result=0;
            foreach (int number in nummbers)
            {
                Result += number;
            }
            return Result;
        }
        public static int Cix(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Vur(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int bol(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
