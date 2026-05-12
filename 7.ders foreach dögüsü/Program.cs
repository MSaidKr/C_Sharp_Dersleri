using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _7.ders_foreach_dögüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü

            //foreach(1;2;3;4)

            //1:değişken türü
            //2:değişken adı
            //3:In
            //4:Liste, koleksiyon, dizi

            //string[] cities = { "rize", "eskişehir", "ankara", "istanbul", "bolu" };
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 22, 234, 345, 343, 4545, 5678, 23468, 243, 5467, 443, 444,9878,1235434 };
            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 22, 234, 345, 343, 4545, 5678, 23468, 243, 5467, 443, 444, 9878, 1235434 };
            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //örnek 1
            //string[] liste = { "emre", "said", "eren", "yunus", "salih", "samet" };
            //foreach (string x in liste)
            //{
            //    Console.Write(x + ", ");
            //}

            //örnek 2
            //Console.WriteLine("Rakamlar:");
            //int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //foreach(int c in sayılar)
            //{
            //    Console.WriteLine(c);
            //}

            //örnek 3
            //List<string> kelimeler = new List<string>() { "kapı", "kalem", "silgi", "bilgisayar", "kupa", "termos" };
            //foreach (string a in kelimeler)
            //{
            //    Console.WriteLine(a);
            //}

            //örnek 4
            //List<string> söz = new List<string>() { "katlan", "hepsi", "anı", "kapı", "kol" };
            //foreach(string c in söz)
            //{
            //    Console.WriteLine(c);
            //}

            //örnek 5
            //string a = "yaz yaz yaz";
            //foreach (char c in a)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region örnek sınav sistemi uygulaması

            //Console.WriteLine("Kaç öğrencinin notunu hesaplamak istiyorsunuz?");
            //int studentnumber = int.Parse(Console.ReadLine());
            //string[] studentnames = new string[studentnumber];
            //double[] studentnotes = new double[studentnumber];
            //int notSayisi = 3;
            //for(int i = 0; i<studentnumber; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin ismini giriniz.");
            //    studentnames[i] = Console.ReadLine();
            //    double totalvalue = 0;
            //    for(int j=0; j<3;j++)
            //    {
            //        Console.Write($"{studentnames[i]} adlı öğrencinin {j+1}. notunu giriniz:");
            //        double value;
            //        double.TryParse(Console.ReadLine(), out value);
            //        totalvalue += value;
            //    }
            //    studentnotes[i] = totalvalue / notSayisi;
            //}
            //for (int g = 0;g<studentnumber;g++ )
            //{
            //    Console.Write($"{studentnames[g]} adlı öğrencinin notu: {studentnotes[g]} ");
            //    if (studentnotes[g]>=50)
            //    {
            //        Console.WriteLine("(geçti)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("(kaldı)");
            //    }
            //}
            #endregion

            #region Üniversite dönem sonu notu hesaplama programı:

            Console.WriteLine("Bu program %40'lık 1 vize ve %60'lık 1 final içeren dersler için hazırlanmıştır.");
            Console.WriteLine("Kaç dersin var?");
            int derssayisi = int.Parse(Console.ReadLine());
            double[] derskredisi = new double[derssayisi];
            string[] dersler = new string[derssayisi];
            double[] vizenotu = new double[derssayisi];
            double[] finalnotu = new double[derssayisi];
            double[] ortalamalar = new double[derssayisi];
            double[] dönemnotu = new double[derssayisi];
            for (int i = 0; i < derssayisi; i++)
            {
                Console.WriteLine($"{i + 1}.dersin adını giriniz.");
                dersler[i] = Console.ReadLine();
                Console.WriteLine($"{dersler[i]} adlı dersin kredisini giriniz.");
                derskredisi[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Dersten aldığınız vize notunu 4 üzerinden giriniz.(0-4)");
                vizenotu[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Dersin final notunu 4 üzerinden giriniz.(0-4)");
                finalnotu[i] = double.Parse(Console.ReadLine());
                ortalamalar[i] = vizenotu[i] * 0.4 + finalnotu[i] * 0.6;
            }
            double value = 0;
            for (int s = 0; s < derssayisi; s++)
            {
                value += derskredisi[s];
            }
            double dönemnotu2 = 0;
            for (int j = 0; j < derssayisi; j++)
            {
                Console.Write($"{dersler[j]} adlı dersin ortalaması: ");
                Console.WriteLine(ortalamalar[j]);
                dönemnotu[j] = ortalamalar[j] * derskredisi[j];
                dönemnotu2 += dönemnotu[j];
            }
            double dönemnotu3 = dönemnotu2 / value;
            Console.WriteLine("Dönem sonu notunuz: " + dönemnotu3);

            #endregion

            Console.Read();
        }
    }
}
