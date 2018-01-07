using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var total = CashRegister.CalculateTotal(catalog, discounts, scannedProduct.ToList());
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }

    public class Product
    {
        public char Code { get; set; }

        public decimal Price { get; set; }

        public Product(char code, decimal price)
        {
            this.Code = code;
            this.Price = price;
        }
    }

    public class Discount
    {
        public char Code { get; set; }

        public int Number { get; set; }

        public decimal Value { get; set; }

        public Discount(char code, int count, decimal value)
        {
            this.Code = code;
            this.Number = count;
            this.Value = value;
        }
    }

    public class CashRegister
    {
        public static decimal CalculateTotal(List<Product> catalog, List<Discount> discounts, List<char> scannedProduct)
        {
            var cart = scannedProduct.GroupBy(p => p);

            var total = cart.Sum(c => catalog.Find(p => p.Code == c.Key).Price * c.Count());

            var discount = 0m;

            foreach (var item in discounts)
            {
                discount += (cart.Any(c => c.Key == item.Code) && cart.First(c => c.Key == item.Code).Count() >= item.Number ?
                            cart.First(c => c.Key == item.Code).Count() * catalog.Find(p=>p.Code == item.Code).Price * item.Value :
                            0);
            }

            return total - discount;
        }
    }
}
