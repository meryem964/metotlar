using System;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product urun1=new Product();
            urun1.Adi = "Elma";
            urun1.Aciklama = "amasya elamsı";
            urun1.Fiyati = 15;


            Product urun2=new Product();
            urun2.Adi = "fındık";
            urun2.Aciklama = "karadeniz fındığı";
            urun2.Fiyati = 80;

            Product urun3 = new Product();
            urun3.Adi = "karpuz";
            urun3.Aciklama = "diyarbakır karpuzu";
            urun3.Fiyati = 90;


            Product[] meyveler = new Product[] {urun1,urun2,urun3 };

            foreach (Product m in meyveler)
            {
                Console.WriteLine(m.Adi+" "+m.Aciklama+" "+m.Fiyati);
            }


            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
            sepetManager.ekle(urun3);
            sepetManager.ekle(urun1);
            // encapsulation
            Console.WriteLine("---------------------------------");
            sepetManager.Ekle2("armut", "yeşil armut",12,10);
            sepetManager.Ekle2("armut", "yeşil armut", 12,9);
            sepetManager.Ekle2("armut", "yeşil armut", 12,8);

            Console.ReadLine();
        }
    }
}
