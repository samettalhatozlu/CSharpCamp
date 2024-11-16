using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number = 3.14;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.99;
            //orangePrice = 21.99;
            //strawberryPrice = 99.99;
            //potatoPrice = 17.99;
            //tomatoPrice = 27.99;

            //Console.WriteLine($"Elma: {applePrice}TL");
            //Console.WriteLine($"Portakal: {orangePrice}TL");
            //Console.WriteLine($"Çilek: {strawberryPrice}TL");
            //Console.WriteLine($"Patates: {potatoPrice}TL");
            //Console.WriteLine($"Domates: {tomatoPrice}TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.535;
            //strawberryGram = 2.525;
            //potatoGram = 0.750;
            //tomatoGram = 1.125;

            //double appleTotalPrice = appleGram * appleGram , orangeTotalPrice = orangeGram * orangePrice, strawberryTotalPrice = strawberryGram *strawberryPrice,
            //    potatoTotalPrice = potatoGram * potatoPrice, tomatoTotalPrice = tomatoGram *tomatoPrice;

            //Console.WriteLine($"Ürün adı: Elma, Birim Fiyat: {applePrice}, Gramaj: {appleGram}, Tutar: {appleTotalPrice}");
            //Console.WriteLine($"Ürün adı: Portakal, Birim Fiyat: {orangePrice}, Gramaj: {orangeGram}, Tutar: {orangeTotalPrice}");
            //Console.WriteLine($"Ürün adı: Çilek, Birim Fiyat: {strawberryPrice}, Gramaj: {strawberryGram}, Tutar: {strawberryTotalPrice}");
            //Console.WriteLine($"Ürün adı: Patates, Birim Fiyat: {potatoPrice}, Gramaj: {potatoGram}, Tutar: {potatoTotalPrice}");
            //Console.WriteLine($"Ürün adı: Domates, Birim Fiyat: {tomatoPrice}, Gramaj: {tomatoGram}, Tutar: {tomatoTotalPrice}");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine($"Toplam Tutar: {shoppingTotalPrice}TL");

            #endregion

            #region Char Değişkenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavye Veri Girişi; String
            //Console.WriteLine("***** Havayolu Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerFullName, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Ad-Soyad: ");
            //passengerFullName = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine($"Yolcu Bilgi Kartı: " +
            //    $"Ad-Soyad: {passengerFullName}, Kimlik: {passengerIdentityNumber}, Şehir: {passengerCity}, Yaş: {passengerAge}");
            #endregion

            #region Klavye Veri Girişi; Int

            //int shoesPrice, computerPrice, chairPrice,tvPrice, shoesCount, computerCount, chairCount, tvCount;

            //shoesPrice = 1000;
            //computerPrice = 10000;
            //chairPrice = 1500;
            //tvPrice = 20000;

            //Console.Write("Lütfen aldığınız ayakkabı adetini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar adetini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız koltuk adetini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız TV adetini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesPrice*shoesCount)+(computerPrice*computerCount)+(chairPrice*chairCount)+(tvPrice*tvCount);

            //Console.WriteLine($"Toplam Tutar: {totalPrice} TL");


            #endregion

            #region Klavyeden Veri Girişi; Double

            //double exam1, exam2, exam3, result;

            //Console.Write("Birinci sınav notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("İkinci sınav notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınav notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;


            //Console.WriteLine($"Ortalamanız: {result}");


            #endregion

            #region Klavyeden Veri Girişi; Char

            char gender;
            Console.Write("Lütfen cinsiyetinizi belirtiniz [e/k]: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine($"Belirtilen cinsiyet: {gender}");
            #endregion




            Console.Read();

        }
    }
}
