using System;
using System.Collections.Generic;
using System.Text;

namespace basicAlgorithm
{
    internal class method1
    {
        public static void method_1() {

            Console.Write("Enter a number: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                int result = num2 * num1;
                Console.Write("Result: " + result);
            }
            else
            {
                    int result = num2 + num1;
                Console.Write("Result: " + result);
            }
        }
    }
}
