using System.Text.Json;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput.ToLower() == "1")
                {
                    var catFood = new CatFood
                    {
                        Description = "Yummy Kitty Cat Food",
                        KittenFood = false,
                        Name = "Yummy Kitty Cat Food",
                        Price = 8.99m,
                        Quantity = 15,
                        WeightPounds = 24.00
                    };

                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
            }
        }
    }
}
