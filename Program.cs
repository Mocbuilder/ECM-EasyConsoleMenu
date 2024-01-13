using System;

namespace ECMPackage
{
    public class ECMItem
    {
        public ECMItem(int input, string name, Action func)
        {
            Input = input;
            Name = name;
            Function = func;
        }
        public int Input { get; set; }
        public string Name { get; set; }

        public Action Function { get; set; }
    }

    public class ECM
    {
        public List<ECMItem> Items = new List<ECMItem>();
        public void Display()
        {
            while (true)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Items[i].Name}");
                }

                Console.WriteLine("Your choice:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Display();
                    return;
                }

                ECMItem? item = Items.FirstOrDefault(i => i.Input == choice);
                if (item == null)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Display();
                    return;
                }
                item.Function.Invoke();
            }
        }
    }  
}