using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            if(operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                Console.WriteLine("Unkown operation.");
                return 0;
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
