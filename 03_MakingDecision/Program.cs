using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else

            //string password;
            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı şifre!");
            //}

            //string capital, country;
            //Console.Write("Başkenti girinizi: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Doğru bilgi");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bilgi");
            //}

            //int exam1, exam2, exam3, average;

            //Console.Write("Birinci sınav notu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sınav notu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınav notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine($"Sınavların ortalaması: {average}");

            //if (average > 0 & average <= 49)
            //{
            //    Console.WriteLine("Sonuç vasat!");
            //}
            //if (average > 49 & average <= 69)
            //{
            //    Console.WriteLine("Sonuç orta");
            //}
            //if (average > 69 & average <= 84)
            //{
            //    Console.WriteLine("Sonuç iyi");
            //}
            //if (average > 84)
            //{
            //    Console.WriteLine("Sonuç çok iyi");
            //}


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "istanbul" | city == "ankara" | city == "gümüşhane" | city == "İzmir")
            //{
            //    Console.WriteLine("Doğru şehir.");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış şehir.");
            //}

            //Console.Write("Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Hatalı kullanıcı adı!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz! ");
            //}
            #endregion

            #region Mod
            //Console.Write("1. sayı: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayı: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write($"Birinci sayınını ikinci sayıdan bölümünden kalanı: {result}");


            //Console.Write("Sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0) {
            //    Console.WriteLine($"Girmiş olduğunuz {number} sayısı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine($"Girmiş olduğunuz {number} sayısı tektir");
            //}

            //Console.Write("Takımınız sembolünü giriniz: ");
            //char symbol = char.Parse(Console.ReadLine());

            //if (symbol == 'g' | symbol == 'G')
            //{
            //    Console.WriteLine("Galatasaray!");
            //}
            //if (symbol == 'f' | symbol == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe!");
            //}
            //if (symbol == 'b' | symbol == 'B')
            //{
            //    Console.WriteLine("Beşiktaş!");
            //}





            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Kamp Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Orman Kebabı");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();


            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();


            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Mix Pizza");
            //    Console.WriteLine("3-Special Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();


            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();


            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Muhallebi");
            //    Console.WriteLine("3-Dilim Baklava");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();


            //}

            #endregion

            #region Switch-Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;

            //    default: Console.Write("Hatalı Veri Girişi!"); break;
            //}

            #endregion

            #region Hesap Makinesi(Switch-Case)

            int number1, number2, result;
            char symbol;

            Console.Write("1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Toplam: {result}"); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"Fark: {result}"); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"Çarpım: {result}"); break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine($"Bölüm: {result}"); break;

                default: Console.WriteLine("Hatalı Giriş!"); break;
            }
            #endregion
            Console.Read();
        }
    }
}
