using ECMPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Testing
    {

        static ECM ecm = new ECM();
        public static void Main(string[] Args)
        {
            ecm.Items.Add(new ECMItem(1, "First Option", Option1));
            ecm.Items.Add(new ECMItem(2, "Second Option", Option2));
            ecm.Items.Add(new ECMItem(3, "Third Option", Option3));

            ecm.Display();
            Console.ReadLine();            
        }

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
