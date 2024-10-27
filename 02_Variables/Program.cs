using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number
            ////number = 4.65;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyatı : " + applePrice + "TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı : " + orangePrice + "TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı : " + strawberryPrice + "TL");
            //Console.WriteLine("-----Patates Birim Fiyatı : " + patatoPrice + "TL");
            //Console.WriteLine("-----Domates Birim Fiyatı : " + tomatoPrice + "TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice= tomatoGram * tomatoPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan ürün Elma = " +  "Birim Fiyat : " + applePrice+  "--Gramaj : "+ appleGram + "--Toplam Tutar : "+ appleTotalPrice);
            //Console.WriteLine("Alınan ürün Portakal = " +  "Birim Fiyat : " + orangePrice +  "--Gramaj : "+ orangeGram + "--Toplam Tutar : "+ orangeTotalPrice);
            //Console.WriteLine("Alınan ürün Elma = " +  "Birim Fiyat : " + strawberryPrice +  "--Gramaj : "+ strawberryGram + "--Toplam Tutar : "+ strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün Elma = " +  "Birim Fiyat : " + patatoPrice +  "--Gramaj : "+ patatoGram + "--Toplam Tutar : "+ patatoTotalPrice);
            //Console.WriteLine("Alınan ürün Elma = " +  "Birim Fiyat : " + tomatoPrice+  "--Gramaj : "+ tomatoGram + "--Toplam Tutar : "+ tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " TL ");
            #endregion

            #region Char Değişkenler
            //ABCDEFGH = sezar şifreleme her karakterin kendinden sonra gelen 3. karakter 
            // A ise d / b ise E / C ise f
            //Toplantı saat 20:00'de
            //' tek tırnakla kullanmılır

            //char symbol;
            //symbol = 'A';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgi Sistemi *****");
            //Console.WriteLine();

            //string pessengerName, pessengerSurname, pessengerDistrict, pessengerCity, pessengerAge, pessengerIdentityNumber;

            //Console.WriteLine("Yolcu Adı :");
            //pessengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadı : ");
            //pessengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi : ");
            //pessengerDistrict = Console.ReadLine();

            //Console.WriteLine("İl Bilgisi : ");
            //pessengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaş : ");
            //pessengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC kimlik Numarası : ");
            //pessengerIdentityNumber = Console.ReadLine();  

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No : " + pessengerIdentityNumber + " - Yolcu Adı Soyadı " + pessengerName + " " + pessengerSurname + " " + pessengerDistrict + " / " + pessengerCity + " " + pessengerAge);

            #endregion

            #region Klavyeden Veri Girişleri İnt Değişkenler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 1200;

            //int shoesCourt, computerCourt, chairCourt, tvCourt;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCourt = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz : ");
            //computerCourt = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz :");
            //chairCourt = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCourt = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCourt * shoesPrice + computerCourt * computerPrice + chairCourt * chairPrice + tvCourt * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken TUtar : " +totalPrice);




            #endregion

            #region Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Birinci sınav notunuzu giriniz : ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Üçüncü sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız " + result);
            #endregion

            #region Klavyeden Char Karakter Girişleri

            //char gender;
            //Console.WriteLine("lütfen cinsiyetinizi giriniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);

            #endregion




















            Console.ReadKey();
        }
    }
}
