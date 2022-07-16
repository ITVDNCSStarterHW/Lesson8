using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static int Factorial(int operand)
        {
            if (operand == 1)
                return 1;
            else
            { 
                return operand * Factorial(operand - 1); ;
            }
        }
        static void Main(string[] args)
        {
            int operand = 8;

            operand = Factorial(operand);
            Console.WriteLine(operand);

            Console.ReadLine();
        }
    }
}
