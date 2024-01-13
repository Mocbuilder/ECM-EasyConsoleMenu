using ECMPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECMTesting
{
    public class Testing
    {

        static ECM ecm = new ECM();
        public static void Main(string[] Args)
        {
            ecm.ECMOptionMethods.Add(1, Option1);
            ecm.ECMOptionMethods.Add(2, Option2);
            ecm.ECMOptionMethods.Add(3, Option3);
            ecm.ECMOptionNames.Add("First Option");
            ecm.ECMOptionNames.Add("Second Option");
            ecm.ECMOptionNames.Add("Third Option");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            ecm.ECMain();
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
