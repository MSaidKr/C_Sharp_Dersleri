using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace üçüncü_ders_if_else_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else
            Console.Write("lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("şifre doğru");
            }
            else
            {
                Console.WriteLine("şifre yanlış");
            }

            string capital, country;
            Console.WriteLine("Başkent giriniz: ");
            capital = Console.ReadLine();
            Console.Write("ülkeyi giriniz: ");
            country = Console.ReadLine();
            if (capital == "ankara" && country == "türkiye")
            {
                Console.WriteLine("veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("hatalı bilgi");

            }
            Console.WriteLine();
            int sayi;
            Console.WriteLine("sayıyı giriniz");
            sayi = int.Parse(Console.ReadLine());
            if (sayi == 5)
            {
                Console.WriteLine("sayı doğru");
            }
            else
            {
                Console.WriteLine("sayı yanlış");
            }

            int exam1, exam2, exam3, average;
            string result;

            Console.WriteLine("sınav1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sınav2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sınav3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
           
            Console.WriteLine("sınavların ortalaması: " + average);
            result = "böyle bir sonuç olamaz";
            
            if (average >= 0 && average < 50)
            {
                //Console.WriteLine("sonuç içler acısı");
                result = "içler acısı";
            }
            else if (average >= 50 && average < 85)
            {
                // Console.WriteLine("fena değil");
                result = "fena değil";
            }
            else if (average >= 85 && average <=100)
            {
                //Console.WriteLine("iyi");
                result = "tebrikler!";
            }
            Console.WriteLine("sonuç: " + result);

            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();
            string city;
            Console.WriteLine("Şehir girişi yapınız.");
            city = Console.ReadLine();
            if (city == "rize" || city == "batman" || city == "eskişehir")
                {
                Console.WriteLine("şehir mevcut");
                }
            else 
            {
                Console.WriteLine("şehir listede bulunmamaktadır.");
            }

            Console.Read();
            #endregion

        }
    }
}
