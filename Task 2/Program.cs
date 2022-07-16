using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static int DeptCalculate(int dept, int payment)
        {
            dept -= payment;

            if (dept <= 0)
            {
                Console.WriteLine("Your overpayment is {0}", dept);
                Console.WriteLine("The dept is repaid");
                return 1;
            }
            else
                {
                Console.WriteLine("The amount of dept is {0}", dept);
                Label1:
                Console.WriteLine("Enter the amount of payment");
                payment = Convert.ToInt32(Console.ReadLine());

                if (payment < 100)
                    {
                    Console.WriteLine("The payment is less than necessary. The Minimum payment is 100");
                    goto Label1;
                    }

                return DeptCalculate(dept, payment);
                }
            
        }

        static void Main(string[] args)
        {
            int payment;
            int dept = 700;

            Console.WriteLine("Your dept is {0}", dept);
            Console.WriteLine("Enter the amount of payment");
            payment = Convert.ToInt32(Console.ReadLine());

            DeptCalculate(dept, payment);

            Console.ReadLine();
        }
    }
}
