using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class choice
    {
        public static void menu() {

            Console.Write("Select activity " +
                "\n1. " +
                "\n2. " +
                "\n3." +
                "\n10. Exit" +
                "\nSelect Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option) { 
                
                case 1:
                    Console.WriteLine("You have selected option 1");
                    break;
                case 2:
                    break;

                case >=10:
                         Console.WriteLine("Exiting...");
                    break;
            }
        }
    }
}
