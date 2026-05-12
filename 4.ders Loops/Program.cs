using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ders_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("said");
            //}

            //int i; 
            //for(i = 1; i < 9; i++ )
            //    Console.WriteLine( "güllük gülistanlkk" );

            //otuza kadar olan tek sayılar
            //for (int i = 1; i <= 30; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("ekrana yaılmasını istrediğiniz adedi girin.");
            //int finishvalue = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("benimki beni taniyür glas glasyas gleyh");
            //}

            #endregion

            #region for döngüsü ile karar yapıları

            //Console.WriteLine("1000'den küçük bir doğal sayı giriniz");
            //int verilendeğer = int.Parse(Console.ReadLine());
            //for (int i = verilendeğer; 0< i ; i--)
            //{
            //    if (i % 25 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("bir sayı giriniz");
            //int i = int.Parse(Console.ReadLine()); 
            //if (i % 2 == 0)
            //{
            //    Console.WriteLine("bu sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("bu sayı tektir");
            //}

            //////////////////////////////% = ...'nın bölümünden kalan.

            //int totalvalue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if( i % 2 == 0 )
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalvalue);

            Console.WriteLine("7'nin katsayılarını görmek için sayı giriniz: ");
            int totalvalue = 0;
            int count = 0;
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayıya kadar 7'ye tam bölünen doğal sayılar: ");
            for (int i = 1; i <= sayi; i++)
            {

                if (i % 7 == 0)
                {
                    totalvalue += i;
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("---------");
            Console.Write("toplamları: ");
            Console.WriteLine(totalvalue);
            Console.WriteLine("---------");
            Console.Write("kaç tane sayı var: ");
            Console.WriteLine(count);

            //Console.WriteLine("kaç saat oldu: ");
            //int s = int.Parse(Console.ReadLine());
            //double bs;
            //bs = Math.Pow( 2, s );
            //Console.WriteLine(bs);





            #endregion

            #region While döngüsü
            //while(şart)

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(":)");
            //    i++;
            //}

            //Console.Write("3'e tam bölünen 10'dan küçük sayılar: ");
            //int i = 0;
            //while (i <= 10)
            //{
            //    if (i%3 == 0) 
            //    { 
            //        Console.Write(i + " ");
            //    }
            //    i++;
            //}

            //int s = 0;
            //int x= 0;
            //while (s <= 10)
            //{
            //    x += s;
            //    s++;
            //}
            //Console.WriteLine(x); 



            #endregion

            #region örnek soru

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını yazdıran kodu yazınız.

            //Console.WriteLine("sayıyı giriniz: ");
            //int birler;
            //int onlar;
            //int yüzler;
            //int sayi;
            //sayi = int.Parse(Console.ReadLine());
            //birler = sayi % 10;
            //onlar = sayi % 100 / 10;
            //yüzler = sayi / 100;
            //Console.WriteLine(yüzler + onlar + birler);



            #endregion

            Console.Read();
        }
    }
}
