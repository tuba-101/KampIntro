namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Açiklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Açiklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Açiklama);
                Console.WriteLine("--------------------------------------");

            }

            Console.WriteLine("foreach end......................");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 4);





        }
    }
}
