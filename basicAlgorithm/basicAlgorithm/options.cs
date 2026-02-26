using System;
using System.Collections.Generic;
using System.Text;

namespace basicAlgorithm
{
    internal class options
    {

        public static void menu() {

            int option;
            Console.Write("Select Activities: " +
                "\n1. Triple Sum for Equal Integers" +
                "" +
                "\n10.Exit" +
                "\nSelect: ");
             option=Convert.ToInt32(Console.ReadLine());

            switch (option) {

                case 1:
                    method1.method_1();
                    break;

                case >=10:
                    Console.Write("Thank you");
                    break;

            }

            
        }
    }
}
