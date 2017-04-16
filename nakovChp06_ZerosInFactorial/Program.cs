using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp06_ZerosInFactorial
{
    class FactorialEndZeros

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive number to check its factorial for end zeros: ");

            string userInp = Console.ReadLine();

            ulong num = 0;

            bool check = ulong.TryParse(userInp, out num);

            if (check != true)
            {
                Console.WriteLine("Please enter a positive integer");
            }

            long factorial = 1;

            for (uint i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of number {0} is {1}", num, factorial);

            ulong zeros = 0;

            while (true)
            {
                
                ulong sum = num / 5;

                if (sum != 0)
                {
                    zeros = zeros + sum;
                    num = sum;

                }

                else
                {
                    Console.WriteLine("The sum of zeros at the end of the factorial {0} is {1}", factorial, zeros);
                    break;
                }
            }
        }
    }
}
