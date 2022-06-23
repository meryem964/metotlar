using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            // array class interface bunlar refeance tiplerdir
            //değer tip =satack
            //heap=refrance tip
            int[] sayialr1 = new int[] { 10, 20, 30 };
            int[] sayialr2 = new int[] { 100,200, 300 };
            sayialr1 = sayialr2;
            sayialr2[0] = 999;
        }
    }
}
