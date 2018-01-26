namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Init
          
         //  Liste Produits

        //  Produit |  Prix
        //  -----------------
        //   A      |  50
        //   B      |  25
        //   C      |  30


                
        //  Discounts

        //  CodeProduit  | Nombre  | %
        //  ------------------------------
        //  A            | 3       | 0.25
        //  B            | 5       | 0.10
                
            #endregion


            Console.WriteLine("Scannez les produits");
            //AABBCC...
            var scannedProduct = Console.ReadLine();

            //TODO
            
            var total = CashRegister.CalculateTotal(catalog, discounts, productsList);
            
            //Affichage du total
            Console.WriteLine(total);
            //Pause program
            Console.ReadLine();
        }
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
