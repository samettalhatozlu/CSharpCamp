using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            ////DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Beyaz";
            //colors[3] = "Siyah";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];
            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Gümüşhane";
            //cities[4] = "Trabzon";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[7] = 10;
            //Console.WriteLine(numbers[7]);


            //string[] cities = { "İstanbul", "Ankara", "Eskişehir" };
            //Console.WriteLine(cities[0]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Kırmızı", "Mor", "Sarı", "Lacivert" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //} 

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 10, 33, 35, 478, 963, 639, 563, 423 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }
            //}

            //int[] myArray = { 10, 27, 456, 87, 536, 5125, 122, 8552, 231, 874 };

            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{

            //    if (myArray[i] > maxNumber)
            //    {

            //        maxNumber = myArray[i];

            //    }
            //}
            //Console.WriteLine(maxNumber);

            //int[] numbers = { 1, 2, 50, 60, 80, 63, 56, 812, 62 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 50, 60, 80, 63, 56, 812, 62 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion


            #region Dizi-Metotlar


            ////İndex Bulma
            //string[] customers = { "Ali", "Veli", "Mehmet", "Samet", "Talha" };
            //int index = Array.IndexOf(customers, "Samet");
            //Console.WriteLine(index);

            ////Min-Max Sayı Bulma
            //int[] numbers = { 1, 2, 60, 50, 80, 92, 21, 306, 556, 32, 82, 9887 };
            //Console.WriteLine($"Dizinin en büyük elemanı: {numbers.Max()}, en küçük elemanı: {numbers.Min()}");



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehrini giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}

            int[] dizi1 = { 10, 20, 30, 40, 50, 66, 36, 33, 39, 93, 13, 17, 33 };

            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < dizi1.Length; i++)
            {
                if (dizi1[i] % 2 == 0)
                {
                    Console.WriteLine(dizi1[i]);

                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < dizi1.Length; i++)
            {
                if (dizi1[i] % 2 == 1)
                {
                    Console.WriteLine(dizi1[i]);

                }
            }


            #endregion



            Console.Read();
        }
    }
}
