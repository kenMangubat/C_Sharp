using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    internal class menu
    {

        public static  void menu1() {


            int choice;
            do
            {
                Console.Write("Menu:" +
                    "\n1. Print Hello and Name" +
                    "\n10. Exit" +
                    "\nSelect Option:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        method1 m1 = new method1();
                        m1.method1_1();
                        break;

                    case 10:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        if(choice>=10)
                        Console.WriteLine("Thank you!");
                        return;
                }

            }
            while (choice != 10);

        }
    }
}
