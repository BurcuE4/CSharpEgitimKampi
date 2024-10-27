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

            //() => Bir yapının method olduğunu anlamak için sonuna mutlaka parantez gelmesi gerekir.
            //Geriye değer döndürmeyen metotlar
            //Void ile çalışır
            //Özellikle geriye değer döndürmeyen metotlar belli işlemleri tekrardan kurtarmak için de programlama da önemli bir yeri ve yapıya sahiptir.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Mehmet Yıldırım");

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müsteri  : " + name + "  " + surname);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşe", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum (int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız ";
            //}
            //customerName();
            //string studentCard()
            //{
            //    string name = "Ali ";
            //    string surName = "Kaya";
            //    return name + " "+ surName ;
            //}
            //Console.WriteLine(studentCard()); 
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar
            // string CountryCard(string countryName, string capital,string flagColor)
            // {
            //     string cardİnfo = ("Ülke: " + countryName + " - Başkent : " + capital + " - Bayrak Rengi : " + flagColor);
            //     return cardİnfo;
            // }
            // string x, y, z;
            // Console.Write("Ülke Adını Giriniz :");
            // x = Console.ReadLine();

            // Console.Write("Başkent Adını Giriniz :");
            // y = Console.ReadLine();

            // Console.Write("Bayrak Rengini Giriniz : ");
            // z= Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren İnt Parmetreli Metotlar

            //int Sum (int number1, int number2)
            //{
            //    int result= number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));
            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
               if (result >=50)
                {
                    return student+ " isimli öğrenci sınavı geçti " + " Ortalama :  " + result;
                }
                else
                {
                    return student + " isimli öğrenci başarısız oldu  " + "Ortalama : " + result;

                }
            }
            Console.WriteLine(ExamResult("Ali", 25,41,55));
            Console.WriteLine(ExamResult("Ayşe", 36,88,33));



            #endregion




            Console.Read();

        }
    }
}
