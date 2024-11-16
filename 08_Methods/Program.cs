using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Samet");
            //    Console.WriteLine("Talha");
            //    Console.WriteLine("Tozlu");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = 3;
            //    Console.WriteLine(x + y + z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);

            //}
            //WriteMethod("Samet");

            //void CustomerMethod(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri adı: {name}, soyadı: {surname}");
            //}
            //CustomerMethod("Samet Talha", "Tozlu");
            //CustomerMethod("Murat", "Yücedağ");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int x, int y, int z)
            //{
            //    int result = x + y + z;
            //    Console.WriteLine(result);
            //}
            //Sum(1,2,3);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{

            //    return "Samet Talha Tozlu";

            //}
            //Console.WriteLine(CustomerName());

            //string StudentCard()
            //{

            //    string fullName = "Samet Talha Tozlu";
            //    return fullName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar
            //string CountryCard (string countryName, string countryFlag, string countryCapital)
            //{

            //    string cardInfo = $"Ülke adı: {countryName}, bayrak: {countryFlag}, başkent: {countryCapital}";
            //    return cardInfo;
            //}

            //string name, flag, capital;
            //Console.Write("Ülke adını giriniz: ");
            //name = Console.ReadLine();
            //Console.Write("Bayrak bilgisini giriniz: ");
            //flag = Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine(CountryCard(name, flag, capital));



            #endregion


            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(10, 20));
            //Console.WriteLine(Sum(30, 20));
            //Console.WriteLine(Sum(50, 40));
            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {

                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {

                    return $"{student} dersi geçti. Ortalaması: {result}";
                }
                else
                {
                    return $"{student} dersi geçemedi. Ortalaması: {result}";
                }
            }
            Console.WriteLine(ExamResult("Samet", 50, 60, 70));
            Console.WriteLine(ExamResult("Talha", 30, 20, 70));
            Console.WriteLine(ExamResult("Tozlu", 100, 100, 100));
            
            #endregion

            Console.Read();
        }
    }
}
