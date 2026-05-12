using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ders_mod_işlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mod işlemleri

            // int number = 26;
            //int result = number % 5;
            // Console.WriteLine(result);

            //Console.WriteLine("1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan = " + result);

            //int number3 = int.Parse(Console.ReadLine());
            //if (number3 % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}

            #endregion

            #region örn uygulama

            Console.WriteLine("********c# restorant menüsü***********");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-ana yemekler");
            Console.WriteLine("2-çorbalar");
            Console.WriteLine("3-pizzalar");
            Console.WriteLine("4-içecekler");
            Console.WriteLine("5-tatlılar");

            string menu;

            Console.WriteLine("detayını görmek istediğiniz menü numarasını seçin: ");

            menu = Console.ReadLine();

            if (menu == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------ana yemekler---------");
                Console.WriteLine();
                Console.WriteLine("5-makarna 150 tl");
                Console.WriteLine("4-piliç bazlamos 290 tl");
                Console.WriteLine("3-pirinç pilav 100 tl");
                Console.WriteLine("2-tavuk sote 250 tl");
                Console.WriteLine("1-bonfile et 510 tl");
            }
            else if (menu == "2")
            {
                Console.WriteLine("-----------çorbalar---------");
                Console.WriteLine();
                Console.WriteLine("1-paça 300tl");
                Console.WriteLine("2-mercimek 50tl");
                Console.WriteLine("3-işkembe 150tl");
                Console.WriteLine("4-yoğurtlu çorba 80tl");
            }
            else if (menu == "3")
            {
                Console.WriteLine("--------pizzalar--------");
                Console.WriteLine();
                Console.WriteLine("1-bol sucuklu karışık 230tl");
                Console.WriteLine("2-mantarlı zeytinli 300tl");
                Console.WriteLine("3-margarita 180tl");
                Console.WriteLine("4-karışık pizza 200tl");
            }
            else if (menu == "4")
            {
                Console.WriteLine("---------içecekler--------");
                Console.WriteLine();
                Console.WriteLine("1-kola 50tl");
                Console.WriteLine("2-fanta 60tl");
                Console.WriteLine("3-su 10tl");
                Console.WriteLine("4-soda 30tl");
            }
            else if (menu == "5")
            {
                Console.WriteLine("---------tatlılar----------");
                Console.WriteLine();
                Console.WriteLine("1-kadayıf 200tl");
                Console.WriteLine("2-baklava 150tl");
                Console.WriteLine("3-tulumba 80tl");
                Console.WriteLine("4-san sebastian 100tl");
                Console.WriteLine("5-ekler 135tl");
            }
            else
            {
                Console.WriteLine("menüde böyle bir numara bulunmamaktadır");
            }
            #endregion

            #region switch case

            //Console.WriteLine("Ay numarası giriniz: ");
            //int monthnumber = int.Parse(Console.ReadLine());
            //    switch (monthnumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default: Console.WriteLine("hatalı veri girişi"); break;
            //}

            #endregion

            #region switch case hesap makinesi

            //double number1, number2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //number1=double.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2=double.Parse(Console.ReadLine());
            //Console.Write("lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol= char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number2 + number1;
            //        Console.WriteLine("toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("sonuç: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break; 
            //    default: 
            //        Console.WriteLine("böyle bir işlem bulunmamaktadır");
            //        break;

            //}


            #endregion

            Console.Read();
        }
    }
}
