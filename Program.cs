using System;

namespace ECMPackage
{
    public class ECM
    {
        public Dictionary<int, Action> ECMOptionMethods = new Dictionary<int, Action>
        {

        };

        public List<string> ECMOptionNames = new List<string>
        {

        };

        public void ECMain()
        {
            for (int i = 0; i < ECMOptionNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ECMOptionNames[i]}");
            }
            string UserInput = Console.ReadLine();
            int UserChoice = Convert.ToInt32(UserInput);
            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine("Option1();");
                    break;
                case 2:
                    Console.WriteLine("Option2();");
                    break;
                case 3:
                    Console.WriteLine("Option3();");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }

    
}