using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rastgeleSayi1 = random.Next(1, 101);
            int rastgelesayi2 = random.Next(1, 1001);
            int rastgelesayi3 = random.Next(1, 10001);

            int tahmin = 0;
            bool dogruTahmin = false;


            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz!");
            Console.WriteLine("Lütfen zorluk seçin: kolay-1 orta-2 zor-3");

            int zorlukseçin = Convert.ToInt32(Console.ReadLine());

            switch (zorlukseçin)
            {
                case 1:
                    while (!dogruTahmin)
                    {
                        Console.WriteLine("sayı tahmin edin");
                        string tahminedilensayı = Console.ReadLine();
                        if (!int.TryParse(tahminedilensayı, out tahmin)) ;



                        if (tahmin > rastgeleSayi1) { Console.WriteLine("tahmininizi azaltın"); }
                        else if (tahmin < rastgeleSayi1) { Console.WriteLine("tahminizi yükseltin"); }

                        else
                        {
                            dogruTahmin = true;
                            Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Tuttuğum sayı {rastgeleSayi1} idi.");

                        }
                    }
                    break;

                case 2:
                    while (!dogruTahmin)
                    {
                        Console.WriteLine("sayı tahmin edin");
                        string tahminedilensayı = Console.ReadLine();
                        if (!int.TryParse(tahminedilensayı, out tahmin)) ;



                        if (tahmin > rastgelesayi2) { Console.WriteLine("tahmininizi azaltın"); }
                        else if (tahmin < rastgelesayi2) { Console.WriteLine("tahminizi yükseltin"); }

                        else
                        {
                            dogruTahmin = true;
                            Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Tuttuğum sayı {rastgelesayi2} idi.");

                        }
                    }
                    break;
                case 3:

                    while (!dogruTahmin)
                    {
                        Console.WriteLine("sayı tahmin edin");
                        string tahminedilensayı = Console.ReadLine();
                        if (!int.TryParse(tahminedilensayı, out tahmin)) ;



                        if (tahmin > rastgelesayi3) { Console.WriteLine("tahmininizi azaltın"); }
                        else if (tahmin < rastgelesayi3) { Console.WriteLine("tahminizi yükseltin"); }

                        else
                        {
                            dogruTahmin = true;
                            Console.WriteLine($"Tebrikler! Doğru tahmin ettiniz. Tuttuğum sayı {rastgelesayi3} idi.");

                        }
                    }
                    break;
            }














            Console.ReadKey();

        }
    }
}
