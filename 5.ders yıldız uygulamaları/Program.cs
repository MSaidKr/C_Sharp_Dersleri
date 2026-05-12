using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ders_yıldız_uygulamaları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region yan yan 10 yıldız oluşturma

            //for (int i = 0; i <= 9; i++) 
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region dik üçgen oluşturma

            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region dik üçgen oluşturma 2

            //for (int i = 9; i >= 0; i--)
            //{   
            //    for (int j = 9; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters dik üçgen oluşturma

            //for (int i = 9; i >= 0; i--)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region soldan ikizkenar üçgen

            //for(int i =0; i <=9; i++)
            //{
            //    for (int j =0; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 9; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region piramit çizimi

            //for (int i = 1; i <= 10; i++)
            //{

            //    for(int j = 10; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 2; k <=2*i ; k++)
            //    {
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region baklava dilimi çizimi

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 2; k <= 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int l = 1; l <= 10; l++)
            {
                for (int x = 1; x <= l; x++)
                {
                    Console.Write(" ");
                }
                for (int y = 20; y >= 2 * l; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion

            Console.Read();
        }
    }
}
