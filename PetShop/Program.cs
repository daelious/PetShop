using System.Text.Json;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();

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

                    productLogic.AddProduct(catFood);
                } else if (userInput.ToLower() == "2")
                {
                    productLogic.GetCatFoodByName("Yummy Kitty Cat Food");
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
            }
        }
    }
}
