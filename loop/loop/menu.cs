using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    internal class menu
    {
        public static void select()
        {
            int option;

            do
            {
                Console.Write("\nMenu: \n1. First 10 natural numbers" +
                    "\n2. Sum of first 10 natural numbers" +
                    "\n3. Sum of n natural numbers" +
                    "\n4. Summation of first 10 numbers" +
                    "\n5. Maximum Patterns" +
                    "\n6.Odd or Even" +
                    "\n7.Never ending loop" +
                    "\n8.Perfect Range" +
                    "\n9.loop Odd or Even" +
                    "\n10. Exit" +
                    "\nSelect: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option) {

                    case 1:
                        loop1.method1();
                        break;

                    case 2:
                        loop2.method2(); 
                        break;

                    case 3:
                        loop2.method3();
                        break;
                    case 4:
                        loop2.method4();
                        break;

                    case 5:
                        loop2.method5();
                        break;

                    case 6:
                        loop2.method6();
                        break;

                    case 7:
                        loop1.method2();
                        break;

                    case 8:
                        loop2.method7();
                        break;

                    case 9:
                        loop1.method3();
                        break;

                    case 10:
                        Console.Write("Salamat sa tanan bai!");
                        break;

                    default:
                        if (option >= 10)
                        {
                            Console.Write("Salamat bai!");
                            return;
                        }
                       
                       
                        break;
                }
            }
            while (option != 10);


        }


    }
}
