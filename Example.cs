using ECMPackage;
using System;
using System.Collections.Generic;

namespace UsageExample
{
    public class Example
    {
        //Define a new instance of the ECM
        static ECM ecm = new ECM();
        public static void Main(string[] Args)
        {
            //Add your options to the ECM Items List
            ecm.Items.Add(new ECMItem(1, "First Option", Option1));
            ecm.Items.Add(new ECMItem(2, "Second Option", Option2));
            ecm.Items.Add(new ECMItem(3, "Third Option", Option3));

            //Format the console output, e.g. the font-color:
            Console.ForegroundColor = ConsoleColor.Green;
            //Display the menu
            ecm.Display();           
        }

        //Your functions, these only write a short text
        public static void Option1()
        {
            Console.WriteLine("This is Option 1 doing something.");
        }
        public static void Option2()
        {
            Console.WriteLine("This is Option 2 doing something.");
        }
        public static void Option3()
        {
            Console.WriteLine("This is Option 3 doing something.");
        }
    }
}
