using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Foreach Döngüsü

            /*foreach(1;2;3;4)
             * 1: değişken türü
             * 2: değişken adı
             * 3: in
             * 4: liste-koleksiyon-dizi
             */

            //string[] cities = { "İstanbul", "Ankara", "Gümüşhane", "İzmir" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 2, 4, 6, 20, 30, 33, 55, 68, 96, 34, 51, 27 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);

            //    }
            //}

            //int[] numbers = { 2, 4, 6, 20, 30, 33, 55, 68, 96, 34, 51, 27 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("*********** C# Sınav Ortalama Hesaplama Uygulaması ***********");
            Console.WriteLine();
            Console.Write("Lütfen öğrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {

                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine() ;
                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
            }
            #endregion
            Console.Read();

        }
    }
}
