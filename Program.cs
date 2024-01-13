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

        public void ECMDisplay()
        {
            for (int i = 0; i < ECMItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ECMItems[i]}");
            }
            Console.WriteLine("Your choice:");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            if (!ECMActions.ContainsKey(choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            ECMActions[choice].Invoke();
        }
    }  
}