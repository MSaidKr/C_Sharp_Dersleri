using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ders_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //1 geriye değer döndürmeyen metotlar
            // void metotlar yani

            //void customerlist()
            //{
            //    Console.WriteLine("muhammed");
            //    Console.WriteLine("said");
            //    Console.WriteLine("karaahmetoğlu");
            //    Console.WriteLine("- Rize");
            //}

            //customerlist();
            //customerlist();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();
            //sum();

            #endregion

            #region geriye değer döndürmeyen parametreli metotlar:

            //void WriteMethod(string customername)
            //{
            //    Console.WriteLine(customername);
            //}
            //WriteMethod("said karaahmetoğlu");

            //void customercard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //customercard("said" ,"karaahmetoğlu");
            //customercard("kadir", "yılmaz");

            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar:

            //void sum(int number1 , int number2, int number3) 
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string customername()
            //{
            //    return "said kara";
            //}
            //customername();

            //string studentcard()
            //{
            //    string name = "ali";
            //        string surname = "kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentcard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            string countrycard(string countryname, string capital, string flagcolor)
            {
                string cardinfo = "ülke: " + countryname + " " + "- başkent: " + capital + "- bayrak rengi: " + flagcolor;
                return cardinfo;
            }
            string x, y, z;
            Console.WriteLine("ülke adını giriniz: ");
            x = Console.ReadLine();
            Console.WriteLine("başkentin adını giriniz: ");
            y = Console.ReadLine();
            Console.WriteLine("bayrak rengini giriniz: ");
            z = Console.ReadLine();
            Console.WriteLine(countrycard(x, y, z));
            Console.WriteLine(countrycard("türkiye", "ankara", "kırmızı-beyaz"));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int sum (int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 67));
            //Console.WriteLine(sum(10, 54));
            //Console.WriteLine(sum(88, 66));
            //Console.WriteLine(sum(56, 98));

            #endregion

            #region Örnek uygulama

            //string examresult( string student ,int exam1, int exam2 , int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. Ortalama: "+ result;
            //    }
            //    else
            //    {
            //        return student +" isimli  öğrenci kaldı. Ortalama: "+ result;
            //    }
            //}
            //Console.WriteLine(examresult("ali", 25, 42, 23));
            //Console.WriteLine(examresult("mehmet", 60, 45, 77));
            //Console.WriteLine(examresult("ayşe", 22, 20, 56));
            //Console.WriteLine(examresult("adem", 55, 12, 43));

            #endregion

            Console.Read();
        }
    }
}
