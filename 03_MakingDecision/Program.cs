using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else 
            //{
            //    Console.WriteLine("Şİfre yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz : ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital== "ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Bilgiler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler yanlış");
            //}

            //int number;
            //Console.WriteLine("Sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı : ");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata ";

            //Console.WriteLine("1. sınavı giriniz : ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sınavı giriniz : ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.WriteLine("3. sınavı giriniz : ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması : " + average);

            //if (average > 0 & average < 50)
            //{
            //    result="Durum vasat";
            //}
            //if (average > 50 & average < 70)
            //{
            //    result="Sonuc orta";
            //}
            //if (average > 70 & average < 84)
            //{
            //    result="Sonuc iyi";
            //}
            //if (average > 84 & average < 100)
            //{
            //    result="Sonuc cok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız : ");
            //city= Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut. ");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil. ");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz : ");
            //string username= Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Girinizi : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünde kalan : " + result);

            //Console.WriteLine("Lütfen sayıyı giriniz : ");
            //int number = int .Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            ////}
            //char team;
            //Console.WriteLine("Lütfen Takım Semboünü Giriniz : ");
            //team=char.Parse(Console.ReadLine());
            #endregion

            #region Char Değişkenler ile karar yapıları

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("GalataSaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FenerBahçe");
            //}
            //if (team == 'b' | team== 'B')
            //{
            //    Console.WriteLine("BeşikTaş");
            //}
            #endregion

            #region Örnek Proje uygulaması 

            //Console.WriteLine("***** C# Eğitim Kampı Restoran ***** ");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1. Ana Yemekler");
            //Console.WriteLine("2. Çorbalar");
            //Console.WriteLine("3. Pizzalar");
            //Console.WriteLine("4. İçecekler");
            //Console.WriteLine("5. Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayıı görmek istediğiniz menü seçimi ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5.Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası ");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Yayla Çorbası ");
            //    Console.WriteLine("4-KellePaça çorbası");
            //    Console.WriteLine("5.İşkembe Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-margarita Pizza");
            //    Console.WriteLine("3-Bol Malzemos pizza");
            //    Console.WriteLine("4-Mangal Pizza");
            //    Console.WriteLine("5.Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Ayran ");
            //    Console.WriteLine("4-Ice Tea");
            //    Console.WriteLine("5.Su");
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Tavuk Göğüsü");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5.Pasta");
            //    Console.WriteLine("------------Tatlılar------------");
            //}







            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay girişi yapınız ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.WriteLine("Hatalı Veri Girişi "); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi
            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. sayıyı giriniz : ");
            //number1 =int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz : ");
            //number2 =int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Yapmak istediğiniz işlemi giriniz ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':

            //     result= number1 + number2;
            //        Console.WriteLine("Toplam " +result);

            //        break;

            //    case '-':

            //        result = number1 - number2;
            //        Console.WriteLine("Fark " + result);

            //        break;
            //    case '*':

            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım " + result);

            //        break;
            //    case '/':

            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm " + result);

            //        break;


            //    default:
            //        break;
            //}
            #endregion











            Console.Read();
        }
    }
}
