using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.Common;

namespace Week1_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter the Numerical Mark:");
            num1 = Convert.ToInt32(Console.ReadLine());


            switch (num1)
            {
                case 10:

                case 9:

                    Console.WriteLine("Excellent");
                    break;

                case 7:
                    Console.WriteLine("Notable");
                    break;

                case 6:
                    Console.WriteLine("Good");
                    break;

                case 5:
                    Console.WriteLine("Pass");
                    break;

                case 4:
                case 3:
                case 2:
                case 1:
                case 0:

                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("You have entered invalid Numerical Mark");
                    break;
            }

        }
    }
}
     