using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ders_diziler
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            #region temel dizi örnekleri

            //DeğişkenTürü [] DiziAdı =new DeğişkenTürü [ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "sarı";
            //colors[3] = "turuncu";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "rize";
            //cities[1] = "ordu";
            //cities[2] = "eskişehir";
            //cities[3] = "bursa";
            //cities[4] = "istanbul";
            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[5];
            //numbers[0] = 53;
            //numbers[1] =16;
            //numbers[2] = 26;
            //numbers[3] = 32;
            //numbers[4] = 52;
            //Console.WriteLine(numbers[3]);

            //string[] cities = { "eskişehir", "istanbul", "ısparta", "çanakkale" };
            //Console.WriteLine(cities[0]);

            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] months = { "nisan", "eylül", "ekim", "mart", "kasım" };
            //for (int i = 0; i < months.Length; i++) 
            //{
            //    Console.WriteLine(months[i]); 
            //}

            //int[] numbers = { 2, 32, 45, 64, 77, 222, 123, 26, 2005 };
            //for (int i = 0; i < numbers.Length; i++)
            //    if (numbers[i]% 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //char[] symbols = { 'e', 's', 'k', 'i', 'ş', 'e', 'h', 'i', 'r' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            //int maxnumber = myarray[0];
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali", "said", "kara", "faruk" };
            //Console.WriteLine(persons.Length);
            #endregion

            #region dizi metodları

            //array.sort(DiziAdı); küçükten büyüğe sıralar

            //int[] numbers = { 1, 2,73, 4, 87,97,68,29 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // reverse metodu diziyi tersten sıralar

            //int[] ints = { 78, 56, 89, 77, 99, 67, 55 };
            //Array.Reverse(ints);
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            //string[] customers = { "ali", "ayşe", "said", "eren" };
            //int index = Array.IndexOf(customers, "said");
            //Console.WriteLine(index);

            //int[] numbers = { 81, 82, 83, 94, 95, 96, 77, 78, 79 }; 
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() +  " dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region kullanıcıdan değer alma

            //$ sembolü {} işareti içerisinde parametresel ifadeler kullanmamızı sağlayan bir semboldür.

            string[] cities = new string[5];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            //int[] numbers = { 31, 92, 93, 94, 95, 86, 87, 88 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 81, 82, 83, 84, 85, 76, 77, 78, 79, 40 };
            //Console.Write("çift sayılar: ") ;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.Write(numbers[i] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("tek sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.Write(numbers[i] + " ");
            //    }
            //}
            //Console.WriteLine("Çift sayılar");
            //int[] numbers = { 12, 33, 4, 67, 89, 88, 77, 54, 45, 55 };
            //for (int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }   
            //}
            //Console.WriteLine("Tek sayılar");
            //for (int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }   
            //}



            #endregion

            Console.Read();
        }
    }
}
