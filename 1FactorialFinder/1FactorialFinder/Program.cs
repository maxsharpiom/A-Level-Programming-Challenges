using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FactorialFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();
            Console.ReadLine();
        }

        static void Factorial()
        {
            FindFactorial(DisplayMenu());
        }

        static int DisplayMenu()
        {
            Console.WriteLine("----- FACTORIAL FINDER -----");
            Console.WriteLine();
            Console.WriteLine("Enter number");
            Console.Write("> ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void FindFactorial(int number)
        {
            int runningTotal = 0;
            bool finished = false;
            while (finished == false)
            {
                if (number-1 == 0)
                {
                    Console.WriteLine(runningTotal);
                    finished = true;
                }
                else
                {
                    runningTotal = number * number - 1;
                    number -= 1;
                }                
            }
            //Console.WriteLine(number);
        }

    }
}
