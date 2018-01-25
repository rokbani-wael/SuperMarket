namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Init
            List<Product> catalog = new List<Product>()
            {
                new Product('A', 50),
                new Product('B', 25),
                new Product('C', 30)
            };

            List<Discount> discounts = new List<Discount>()
            {
                new Discount('A', 3, 0.25m),
                new Discount('B', 3, 0.10m)
            };
            #endregion


            Console.WriteLine("Scan products");
            //AABBCC...
            var scannedProduct = Console.ReadLine();

            //TODO
            
            var total = CashRegister.CalculateTotal(catalog, discounts, productsList);
            
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }

    public class Product
    {
        //TODO
    }

    public class Discount
    {
        //TODO
    }

    public class CashRegister
    {
        public static decimal CalculateTotal(List<Product> catalog, List<Discount> discounts, List<char> scannedProduct)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
