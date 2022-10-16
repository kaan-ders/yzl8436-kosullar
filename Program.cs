using System;

namespace yzl_8436_kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oy verme yaşı kontrolü

            /*int yas = 0;

            Console.Write("Lütfen yaşınızı giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());

            if(yas >= 18)
            {
                Console.WriteLine("Oy verebilirsiniz");
                Console.WriteLine("Belki");
            }
            else
                Console.WriteLine("Oy veremezsiniz");

            Console.Read();*/

            //kargo hesaplama

            string ulke, paraBirimi = "USD";
            int kargoUcreti = 50;

            Console.Write("Lütfen ülkenizi girin: ");
            ulke = Console.ReadLine();

            if(ulke == "Türkiye")
            {
                kargoUcreti = 15;
                paraBirimi = "TL";
                //Console.WriteLine("Ödemeniz gereken kargo ücreti: " + 15 + " TL'dir");
            }
            /*else
            {
                kargoUcreti = 50;
                paraBirimi = "USD";
                //Console.WriteLine("Ödemeniz gereken kargo ücreti: " + 50 + " USD'dir");
            }*/

            Console.WriteLine("Ödemeniz gereken kargo ücreti: " + kargoUcreti + " " + paraBirimi + "'dir");
            Console.Read();


            //sayi1
            //sayi2
            //işlemi girin
        }
    }
}