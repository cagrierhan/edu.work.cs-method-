using System;

namespace metodlar.odev
{
    class Program
    {
        public static void CarpimTablosu()
        {
            for (int x = 1; x <= 10; x++) 
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.Write("{0}*{1}={2}\t", y, x, (x * y));
                }
            }
        }
        public static void MetinSay()
        {
            Console.WriteLine("İfade Giriniz : ");
            string metin = Console.ReadLine();
            int uzunluk = metin.Length;
            Console.WriteLine("Uzunlugu = " + uzunluk);
            Console.ReadLine();
        }
        public static void ToplaCarp()
        {
            {
                Console.WriteLine("x : ");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("y : ");
                var b = int.Parse(Console.ReadLine());
                var carpim = 0;
                for (var i = 1; i <= a; i++)
                {
                    carpim += b;
                }
                Console.WriteLine($"Carpma islemi sonucu: {carpim}\n\n");
            }
        }
        public static void VizeFinal(int v,
        int f)
        {

            float ort;
            ort = (v * 40 / 100) + (f * 60 / 100);
            Console.WriteLine("Ortalamanız: " + ort);

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
