using System.Text.Json;

namespace PetShop
{
    internal class Program
    {
        public static void AddProductAction(ProductLogic productLogic)
        {
            Console.WriteLine("Enter a product:");
            Console.WriteLine("\t1. Cat Food");
            Console.WriteLine("\t2. Dog Leash");
            string userInput = Console.ReadLine();

            userInput = Console.ReadLine();
            int selection = int.Parse(userInput);
            Product product = new Product();

            switch (selection)
            {
                case 1:
                    product = new CatFood
                    {
                        Description = "Yummy Kitty Cat Food",
                        KittenFood = false,
                        Name = "Yummy Kitty Cat Food",
                        Price = 8.99m,
                        Quantity = 15,
                        WeightPounds = 24.00
                    };
                    break;
                case 2:
                    product = new DogLeash
                    {
                        Name = "Doggy No Go Leash",
                        Description = "Purple Doggy No Go Leash",
                        LengthInches = 6,
                        Material = "Nylon",
                        Price = 18.99m,
                        Quantity = 24
                    };
                    break;
                default:
                    break;
            }

            if (product != null)
            {
                productLogic.AddProduct(product);
            }
        }

        private static void LookUpProductAction(ProductLogic productLogic)
        {
            Console.WriteLine("Enter which kind of product to lookup:");
            Console.WriteLine("\t1. Cat Food");
            Console.WriteLine("\t2. Cat Food");

            int category = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            switch (category)
            {
                case 1:
                    productLogic.GetCatFoodByName(name);
                    break;
                case 2:
                    productLogic.GetDogLeashByName(name);
                    break;
            }
        }

        private static void DisplayPrompt()
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to look up a product");
            Console.WriteLine("Type 'exit' to quit");
        }

        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();
            string userInput;
            bool isRunning = true;

            do
            {
                DisplayPrompt();
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "1":
                        AddProductAction(productLogic);
                        break;

                    case "2":
                        LookUpProductAction(productLogic);
                        break;

                    case "exit":
                        isRunning = false;
                        break;
                }

            } while (isRunning);
        }
    }
}
