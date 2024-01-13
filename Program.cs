using System;

namespace ECMPackage
{
    public class ECM
    {
        public Dictionary<int, Action> ECMActions = new Dictionary<int, Action>
        {

        };

        public List<string> ECMItems = new List<string>
        {

        };

        public void ECMain()
        {
            for (int i = 0; i < ECMItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ECMItems[i]}");
            }
            Console.Write("\n");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (ECMActions.ContainsKey(choice))
                {
                    ECMActions[choice].Invoke();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    
}