using System.Net.Http.Headers;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string>() { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add(isimler2[4]);
            Console.WriteLine(isimler2[4]);

        }
    }
}
