using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Hello World");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorba");
            //Console.WriteLine("2-Ana Yemek");
            //Console.WriteLine("3-Soğuk Başlangıç");
            //Console.WriteLine("4-Salata");
            //Console.WriteLine("5-Tatlı");
            //Console.WriteLine("6-İçecek");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");


            #endregion

            #region String Değişkenler

            //String Değişkenler

            //string fullName = "Samet Talha Tozlu";
            //Console.WriteLine(fullName);

            //string customerName = "Samet Talha";
            //string customerSurname = "Tozlu";
            //string customerPhone = "+90 555 555 55 55";
            //string customerEmail = "software@gmail.com";
            //string customerCity = "İzmir";
            //string customerDistrict = "Konak";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine($"Müşteri: {customerName} {customerSurname}");
            //Console.WriteLine($"Telefon: {customerPhone}");
            //Console.WriteLine($"Mail: {customerEmail}");
            //Console.WriteLine($"Adres: {customerDistrict},{customerCity}");
            //Console.WriteLine("----------------------------------------");

            ////Dipnot: String interpolasyonu kullanılmıştır. => $""

            //customerName = "Ahmet";
            //customerSurname = "Tozlu";
            //customerPhone = "+90 444 444 55 55";
            //customerEmail = "software_2025@gmail.com";
            //customerCity = "İstanbul";
            //customerDistrict = "Beşiktaş";

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine($"Müşteri: {customerName} {customerSurname}");
            //Console.WriteLine($"Telefon: {customerPhone}");
            //Console.WriteLine($"Mail: {customerEmail}");
            //Console.WriteLine($"Adres: {customerDistrict},{customerCity}");
            //Console.WriteLine("----------------------------------------");

            #endregion

            #region Int Değişkenler

            //int number = 21;
            //Console.WriteLine(number);

            int hamburgerPrice = 400;
            int cokePrice = 50;
            int waterPrice = 15;
            int friesPrice = 50;
            int pizzaPrice = 150;
            int lemonadePrice = 100;

            Console.WriteLine("***** Restoran Menü *****");
            Console.WriteLine();
            Console.WriteLine($"----Hamburger: {hamburgerPrice} TL");
            Console.WriteLine($"----Pizza: {pizzaPrice} TL");
            Console.WriteLine($"----Patates: {friesPrice} TL");
            Console.WriteLine($"----Kola: {cokePrice} TL");
            Console.WriteLine($"----Su: {waterPrice} TL");
            Console.WriteLine($"----Limonata: {lemonadePrice} TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü *****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 2;
            pizzaCount = 1;
            lemonadeCount = 3;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            int totalFullPrice = totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice + totalCokePrice + totalLemonadePrice;

            Console.WriteLine("***** Sipariş Fişi *****");
            Console.WriteLine();
            Console.WriteLine($"Hamburger: {totalHamburgerPrice}");
            Console.WriteLine($"Kola: {totalCokePrice}");
            Console.WriteLine($"Su: {totalWaterPrice}");
            Console.WriteLine($"Patates: {totalFriesPrice}");
            Console.WriteLine($"Pizza: {totalPizzaPrice}");
            Console.WriteLine($"Limonata: {totalLemonadePrice}");
            Console.WriteLine();
            Console.WriteLine($"Toplam Tutar: {totalFullPrice}");
            Console.WriteLine();
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler!");
            #endregion

            Console.Read();


        }
    }
}
