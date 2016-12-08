using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odenti.Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("\nToplam Ödenti Miktarını Giriniz\t:");
            int tom = Convert.ToInt32(Console.ReadLine());
            
            int GmPayi = tom * 20 / 100;
            int IlPayi = (tom - GmPayi) * 20 / 100;
            int Ustorg = (GmPayi + IlPayi);
            int IlcePayi = tom - (GmPayi + IlPayi);

            Console.WriteLine("\nGenel Merkez Payi\t\t:{0} TL", GmPayi);
            Console.WriteLine("\nİl Merkezi Payi\t\t\t:{0} TL", IlPayi);
            Console.WriteLine("\nToplam Üst Örgüt Miktarı\t:{0} TL", Ustorg);
            Console.WriteLine("\nİlçe Merkezi Payi\t\t:{0} TL", IlcePayi);

            Console.ReadKey();
            */
            Console.Write("\nİlçe Payını Giriniz\t\t\t:");
            double IlcePayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nToplam Banka Kesintisini Giriniz\t:");
            double kesinti = Convert.ToDouble(Console.ReadLine());

            double tom = ((IlcePayi + kesinti) * 100 / 64 );
            double GPayi = (tom * 20 / 100);
            double IPayi = (tom * 16 / 100);
            double tum = (GPayi + IPayi);


            Console.WriteLine("\nGenel Merkez Payi\t\t\t:{0} TL", GPayi);
            Console.WriteLine("\nİl Merkezi Payi\t\t\t\t:{0} TL", IPayi);
            Console.WriteLine("\nToplam Üst Örgüt Miktarı\t\t:{0} TL", tum);
            Console.WriteLine("\nToplam Ödenti Miktarı\t\t\t:{0} TL", tom);

            Console.ReadKey();
            

        }
    }
}
