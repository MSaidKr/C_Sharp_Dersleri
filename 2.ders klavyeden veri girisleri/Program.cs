using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ders_klavyeden_veri_girisleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region örnek1        
            //Console.WriteLine("Adınız =?");
            //string Ad;
            //Ad = Console.ReadLine();
            //Console.WriteLine("soy_adınız?");
            //string soy_ad;
            //soy_ad = Console.ReadLine();
            //Console.WriteLine("tam adınız= " + Ad + " " + soy_ad);
            #endregion

            #region klavyeden veri girişleri string değişkenler

            //Console.WriteLine("C_sharp hava yolları yolcu bilgiler");
            //string passengerage;
            //string passengeridnumber;
            //string passengername;
            //string passengersurname;
            //Console.Write("yolcu adı nedir?:");
            //passengername = Console.ReadLine();
            //Console.Write("yolcu soy adı nedir?");
            //passengersurname = Console.ReadLine();
            //Console.Write("yolcu yaşı nedir?");
            //passengerage = Console.ReadLine();
            //Console.Write("id numaranızı giriniz");
            //passengeridnumber = Console.ReadLine();

            //Console.WriteLine("**C-sharp hava yolları yolcu bilgileri:**");
            //Console.WriteLine("adı: " + passengername);
            //Console.WriteLine("soy adı: " + passengersurname);
            //Console.WriteLine("id: " + passengeridnumber);
            //Console.WriteLine("yaş: " + passengerage);



            #endregion

            #region Praktikler

            //arduino kod tanımlama pratiği:

            //int hesapla(int x, int y)
            //{
            //    return (x + y) / 2 + 5;
            //}
            //int a = 5;
            //int b = 7;
            //int sonuc = 0;
            //sonuc = hesapla(a, b);
            //Console.WriteLine(sonuç);

            //pratik 2:

            //int hesapla2(int x, int y, int z)
            //{
            //    return (x + y) / z;
            //}
            //int a = 3;
            //int b = 5;
            //int c = 4;
            //int sonuc;
            //sonuc = hesapla2(a, b, c);
            //Console.WriteLine(sonuc);

            //gelişmiş praitk:

            int toplam = 0;
            Console.WriteLine("Sınav sayınızı giriniz.");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{i + 1}. sınav notunuzu giriniz.");
                toplam += int.Parse(Console.ReadLine());
            }
            int oranlayici(int m, int v)
            {
                return (m / v);
            }
            int sonuç = oranlayici(toplam, a);
            Console.WriteLine("Notunuz =" + sonuç);
            if (sonuç <= 50)
            {
                Console.WriteLine("Başarısızsınız.");
            }
            else
            {
                Console.WriteLine("Başarılısınız!");
            }

            //sayı ortalaması alma pratiği:

            //int ortalama(int c, int b)
            //{
            //    return ((c + b) / 2);
            //}
            //Console.WriteLine("ortalamasını almak istediğiniz iki sayıyı giriniz");
            //Console.WriteLine("1. sayı = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayı = ");
            //int y = int.Parse(Console.ReadLine());
            //int z = ortalama(x, y);
            //Console.WriteLine("sonucunuz = " + z);


            #endregion



        }
    }
}

