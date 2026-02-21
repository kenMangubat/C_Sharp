using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    internal class loop2
    {
        //Write a C# Sharp program to find the sum of the first 10 natural numbers.
        public static void method2()
        {
            int j, sum = 0;

            Console.Write("\nSum of first 10 natural numbers");
            for (j = 1; j <= 10; j++) { 
            
                sum=sum+j;

               
            }
            Console.Write("\nSum: " + sum);
        }

        //Write a C# Sharp program that displays the sum of n natural numbers
        public static void method3() {

            int i, n, sum = 0;

            Console.Write("\nEnter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" " + n);


            for (i = 1; i <= n; i++) {
               

                sum += i;
            }
            Console.Write("\nSum: " + sum);
        }
        //Write a C# Sharp program to read 10 numbers and find their average and sum.
        public static void method4() {

            Console.Write("\nEnter first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Fourth Number: ");
            int num4=Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 5th Number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 6th Number: ");
            int num6 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 7th Number: ");
            int num7 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 8th Number: ");
            int num8 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 9th Number: ");
            int num9 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter 10th Number: ");
            int num10 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;

            double average = sum / 10;


            Console.Write("\nSum: " + sum);
            Console.Write("\nAverage: " + average);

        }

        //Write a program in C# Sharp to display a right angle triangle with an asterisk.The pattern like
        public static void method5() {

            int i, j;
            Console.Write("Enter maximum rows of Asterisk: ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (i = 1; i <= n; i++) 
            {
                for (j = 1; j <=i ; j++) 
                { 
                Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        //Odd or Even
        public static void method6() {

            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2== 0) { 
            
                Console.Write("Even");
            }
            else
            {
                Console.Write("Odd");
            }
        }

        // Find perfect numbers within a given range of number
        public static void method7() {

            int n, i, m;

            Console.Write("Enter starting number: ");
            int starting = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number: ");
            int ending = Convert.ToInt32(Console.ReadLine());

            Console.Write("Perfect numbers within the given range: ");

            for(n=starting; n<=ending; n++) {

              
                m = 0;

                for (i = 1; i < n; i++) {

                    if (n % i == 0) {
                        m = m + i;
                    }  
                }
                if (m == n && n != 0)
                {

                    Console.Write(" " + n);
                }

            }

        }

    }
}
