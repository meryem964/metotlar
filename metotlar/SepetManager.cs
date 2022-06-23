using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class SepetManager
    { 
        public void ekle(Product urun)
        {
            Console.WriteLine("tebrikler sepete eklendi:" +urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklma, double fiyat, int stokadedi)
        {
            Console.WriteLine("tebrikler sepete eklendi:" + urunadi);
        }
    }
}
