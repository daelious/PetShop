namespace PetShop
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;

        public ProductLogic() 
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            try
            {
                if (product is DogLeash)
                {
                    _dogLeashes.Add(product.Name, product as DogLeash);
                }
                else if (product is CatFood)
                {
                    _catFoods.Add(product.Name, product as CatFood);
                }

                _products.Add(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return _dogLeashes[name];
        }

        public CatFood GetCatFoodByName(string name)
        {
            return _catFoods[name];
        }
    }
}
