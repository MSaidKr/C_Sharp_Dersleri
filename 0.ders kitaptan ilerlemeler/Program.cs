using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ders_0_kitaptan_ilerlemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region uygulama 8 (takım örneği)



            Console.WriteLine("tuttuğunuz takımın baş harfini giriniz?");
            string takım;
            takım = Console.ReadLine();
            if (takım == "g")
            {
                Console.WriteLine("galatasaray");
            }
            if (takım == "b")
            {
                Console.WriteLine("beşiktaş");
            }
            if (takım == "f")
            {
                Console.WriteLine("fenerbahçe");
            }
            if (takım == "t")
            {
                Console.WriteLine("trabzon spor");
            }
            if (takım == "r")
            {
                Console.WriteLine("rize spor");
            }
            if (takım == "s")
            {
                Console.WriteLine("sivas spor");
            }

            #endregion



            #region uygulama 9 (bölünme sorusu)



            Console.WriteLine("6'ya bölünen bir sayı giriniz.");

            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0 & sayi % 3 == 0)

            {

                Console.WriteLine("sayı 6'nın bir katı");

            }

            else

            {

                Console.WriteLine("sayı 6'nın bir katı değil");

            }

            #endregion



            #region uygulama 10 (5 meyve çevirme örneği)



            Console.WriteLine("1-portakal ");

            Console.WriteLine("2-elma");

            Console.WriteLine("3-muz");

            Console.WriteLine("4-şeftali");

            Console.WriteLine("5-ananas");

            Console.WriteLine("Çevirmek istediğiniz kelimeyi seçiniz");

            Console.WriteLine("-------------------------------------");

            int seçim = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            switch (seçim)

            {

                case 1: Console.WriteLine("orange"); break;

                case 2: Console.WriteLine("apple"); break;

                case 3: Console.WriteLine("banana"); break;

                case 4: Console.WriteLine("peach"); break;

                case 5: Console.WriteLine("pineapple"); break;

            }

            #endregion



            #region rastgele uygulamalar 1 (lotr karakterleri)



            Console.WriteLine("Adını görmek istediğiniz ırkın numarasını girin.");

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("1-Elf");

            Console.WriteLine("2-Goblin");

            Console.WriteLine("3-İnsan");

            Console.WriteLine("4-Büyücü");

            Console.WriteLine("5-Cüce");

            Console.WriteLine();

            int seçim = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");

            switch (seçim)

            {

                case 1: Console.WriteLine("Legolas"); break;

                case 2: Console.WriteLine("Gobiln Town King"); break;

                case 3: Console.WriteLine("Aragorn"); break;

                case 4: Console.WriteLine("Gandalf the gray"); break;

                case 5: Console.WriteLine("Gimli"); break;

            }



            #endregion



            #region rastgele uygulamalar (dizi uygulamaları)



            string[] şehirler = new string[5];

            şehirler[0] = "rize -bilgi-";

            şehirler[1] = "eskişehir -bilgi-";

            şehirler[2] = "bolu -bilgi-";

            şehirler[3] = "artvin -bilgi-";

            şehirler[4] = "samsun -bilgi-";

            Console.WriteLine("1-rize\n2-eskişehir\n3-bolu\n4-artvin\n5-samsun");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("görmek istediğiniz şehrin sırasını girin.");

            Console.WriteLine();

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            Console.WriteLine(şehirler[a - 1]);



            string[] samuraylar = { "kappa", "kinemon", "ashura", "ken" };

            for (int i = 0; i < samuraylar.Length; i++)

            {

                Console.WriteLine(samuraylar[i]);

            }



            string[] sehirler = { "rize", "eskişehir", "trabzon", "istanbul", "artvin", "ankara", "adana" };

            Console.WriteLine("1-rize\n2-eskişehir\n3-trabzon\n4-istanbul\n5-artvin\n6-ankara\n7-adana");

            Console.WriteLine("plakasını görmek istediğiniz şehrin numarasını girin");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");

            string[] plakalar = { "53", "26", "61", "32", "08", "06", "01" };

            Console.WriteLine(sehirler[x - 1] + " " + plakalar[x - 1]);



            string[] insancıklar = { "said:", "ali:", "ahmet:", "muhammed:" };

            Console.WriteLine("Favori insan numaranızı girin: \n1-said\n2-ali\n3-ahmet\n4-muhammed");

            Console.WriteLine();

            int özellik = int.Parse(Console.ReadLine());

            string[] özellikleri = { "Çok konuşuyor", "Gıcık", "Sevimsiz", "Hiç konuşmuyor" };

            Console.WriteLine(insancıklar[özellik - 1] + " " + özellikleri[özellik - 1]);



            string[] ducks = { "ördekboi", "bırcı", "watson", "nıeve", "architechra", "attalian" };

            Console.WriteLine("altı ördek bir katil ama sence kim? ördeğin numarasını gir.\n1-ördek boi\n2-gownwer\n3-watson\n4-nieve\n5-architechra\n6-attalian");

            Console.WriteLine("----------------------");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(ducks[x - 1] + " adlı ördek katildi iyi iş çıkardın <3");



            #endregion



            #region Hikayeli Uygulamalar



            Console.WriteLine("bu sabah başıma ... numaralı olay geldi. (1-5 arası bir sayı)");

            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------");

            switch (c)

            {

                case 1: Console.WriteLine("bu sabah uyandığımda tavanda bir örümcek gördüm"); break;

                case 2: Console.WriteLine("bu sabah uyandığımda tavana baktım"); break;

                case 3: Console.WriteLine("bu sabah uyandığımda kendimi gördüm"); break;

                case 4: Console.WriteLine("bu sabah uyandığımda ilk olarak telefonuma baktım"); break;

                case 5: Console.WriteLine("bu sabah uyandığımda yerdeki terliğime baktım"); break;

            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("sonrasında ... numaralı olay oldu. (1-4 arası bir sayı)");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------");

            switch (a)

            {

                case 1: Console.WriteLine("sonra onu görmezden gelme kararı aldım."); break;

                case 2: Console.WriteLine("sonra sırtımı döndüm"); break;

                case 3: Console.WriteLine("sonra onu yedim"); break;

                case 4: Console.WriteLine("sonra dedim boşver"); break;

            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("son olarak da ... numaralı olay oldu. (1-5 arası bir sayı)");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------");

            switch (b)

            {

                case 1: Console.WriteLine("son olarak da afiyet olsun dedim."); break;

                case 2: Console.WriteLine("son olarak da taşınma kararı aldım.(böyle ev mi olur?)"); break;

                case 3: Console.WriteLine("son olarak da yatağın altına girip biraz da orda uyudum."); break;

                case 4: Console.WriteLine("son olarak da bu kodu yazdım."); break;

                case 5: Console.WriteLine("son olarak da kafamı koyup uyudum."); break;

            }



            #endregion



            Console.ReadLine();
        }
    }
}

