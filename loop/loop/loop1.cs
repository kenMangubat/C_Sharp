using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    internal class loop1
    {
        //Display first 10 natural numbers
        public static void method1() {

            Console.Write("First 10 natural numbers: ");

            for(int i=1; i<=10; i++) { 
                Console.Write(" "+i);
            }
            Console.Write("\nDecrement: ");
            for (int j = 10; j>= 0; j--)
            {
                Console.Write(" " + j);
            }
        }

        //infinite loop
        public static void method2() {

            while (true)
            {
                Console.Write("\n1.Infinite" +
                               "\n2. Stop" +
                               "\nSelect Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 2)
                {
                    break;
                }
            }
           
        }
        /*Problem 1: Even or Odd Counter
            Instructions:
            Create a program that:
            Asks the user to enter 10 integers.
            Uses a loop to input the numbers.
            Uses if-else to determine if each number is even or odd.
            Displays the total count of even and odd numbers. */
        public static void method3() { 

            int evenCount = 0;
            int oddCount = 0;

            for (int i=1; i<= 10;i++) {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else {

                    oddCount++;
                }

            }

            Console.Write("Total Even Numbers: "+evenCount);
            Console.Write("\nTotal Odd Numbers: " + oddCount);
        }
    }
}
