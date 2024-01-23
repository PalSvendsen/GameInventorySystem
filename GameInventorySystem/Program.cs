using GameInventorySystem;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        PlayerInventory playerInventory = new PlayerInventory();

        playerInventory.Items.Add(new Consumable("Health Potion", "Restores health", 0.2, 20, 0));
        playerInventory.Items.Add(new Weapon("Sword", "A sharp weapon", 2.5, 15));
        playerInventory.Items.Add(new ConsoleItem ("PlayStation 5", "Next-gen gaming console", 10.0, "PlayStation" ));

        playerInventory.DisplayInventory();

        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Use an item");
            Console.WriteLine("2. Display inventory information");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the index of the item to use:");
                    if (int.TryParse(Console.ReadLine(), out int useIndex) && useIndex >= 0 && useIndex < playerInventory.Items.Count)
                    {
                        playerInventory.Items[useIndex].Use();
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please try again.");
                    }
                    break;

                case "2":
                    playerInventory.DisplayInventory();
                    break;

                case "3":
                    Console.WriteLine("Exiting the game. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
