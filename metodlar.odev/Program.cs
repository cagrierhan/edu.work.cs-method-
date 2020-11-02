using System;

namespace metodlar.odev
{
    class Program
    {
        public static void CarpimTablosu() //Metod düzenleneceks
        {
            for (int x = 1; x <= 10; x++) 
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.Write("{0}*{1}={2}\t", y, x, (x * y));
                }
            }
        }
        
        public static void MetinSay(string metin)
        {  
            int uzunluk = metin.Length;
        }
        public static void ToplaCarp(int x , int y)
        {
            {
                var a = int.Parse(x);
                var b = int.Parse(y);
                var carpim = 0;
                for (var i = 1; i <= a; i++)
                {
                    carpim += b;
                }
            }
        }
        public static void VizeFinal(int v,
        int f)
        {

            float ort;
            ort = (v * 40 / 100) + (f * 60 / 100);

        }
        public static void  BuyukSayi ()
        {
            Console.WriteLine("ilk sayiyi girin: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi girin: ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Buyuk olan sayi: {(a > b ? a : b)} \n\n");
        }

        static void Main(string[] args)
        {
            CarpimTablosu();
            MetinSay();
            ToplaCarp();
            VizeFinal(70, 80);
            BuyukSayi();
        }
    }
}
