using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi: " + product.Adi);
        }

        //classlarla değil de veriyi ayrı da verebiliriz ama böyle yapma çünkü ekstra parametre eklediğinde
        //mesela stokAdedi gibi main methodda bu parametrelere
        //karşılık gelen değerleri de vermen gerektiğine dair hata vercek her nerden çağırdıysan methodları
        //buna encapsulation deniyor.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete eklendi2: " + urunAdi);
        }
    }
}
