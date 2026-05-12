using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Değişkenler;
            string customerName;
            string customerold;
            customerold = "38";
            customerName = "Said";
            Console.WriteLine(customerName);
            Console.WriteLine(customerold);
            Console.WriteLine("*******************************************************");
            #endregion

            #region İnt Değişkenler
            int number = 24;
            Console.WriteLine(number);

            int hamburgerprice = 300;
            int limonataprice = 35;
            int siparisprice = 10;
            Console.WriteLine("***menü***");
            Console.WriteLine();
            Console.WriteLine("hamburger = " + hamburgerprice + "TL");
            Console.WriteLine("limonata = " + limonataprice + "TL");
            Console.WriteLine("siparis = " + siparisprice + "TL");

            int totalhamburgerprice;
            int totallimonataprice;
            int totalsiparisprice;
            int count = 1;
            int hamburgercount = 3;
            int limonatacount = 2;
            totallimonataprice = limonataprice * limonatacount;
            totalhamburgerprice = hamburgerprice * hamburgercount;
            totalsiparisprice = siparisprice * count; 
            Console.WriteLine("fiyat: " + totallimonataprice);
            Console.WriteLine("fiyat: " + totalhamburgerprice);
            Console.WriteLine("fiyat: " + totalsiparisprice);
            int total1price = totallimonataprice + totalsiparisprice + totalhamburgerprice;
            Console.WriteLine("net ücret: "+ total1price);
            Console.WriteLine("***********************************************************************************");
            #endregion

            #region Double değişkenler
            double elmaprice;
            elmaprice = 3.56;
            Console.WriteLine("elma birim fiyatı: " + elmaprice);
            double armut = 4.78;
            Console.WriteLine("armut birim fiyat: " + armut );
            double sayi;
            Console.WriteLine("kaç kilo almak istiyorsunuz?");
            sayi = int.Parse(Console.ReadLine());
            double sonuc = sayi * (3.56 + 4.78);
            Console.WriteLine(sonuc);
            Console.WriteLine("***********************************************************************************");
            #endregion

            #region Kullanıcıya sorma
            Console.WriteLine("adiniz nedir?");   
            string ad;
            ad = Console.ReadLine(); 
            Console.Write("soy ad?"); 
            string soy_ad;
            soy_ad = Console.ReadLine(); 
            Console.WriteLine(ad + " " + soy_ad);
            
            Console.Read();
            #endregion
        }
    }
}
