using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foeach (1,2,3,4)
            //1 Değişken Türü
            //2 Değişken Adı
            //3 In
            //4 Liste Koleksiyonu

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };
            //foreach (int x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0) 
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 22, 33, 41, 205, 6578, 10394 };

            //int total= 0;
            //foreach (int i in numbers)
            //{
            //    total += i; 
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int> ()
            //{
            //  1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //string word = "Merhaba "; // kelimeyi parçalara böldük
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentnames= new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i=0; i<studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz : ");
                studentnames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu giriş..
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentnames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                     totalExamResult += value; //notları topluyoruz.
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            Console.WriteLine();

            //sınav ortalaması
            for (int i = 0; i <studentCount; i++)
            {
                Console.WriteLine("--------------------------------------");

                Console.WriteLine($"{studentnames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]} ");
                //öğrencinin ortalamasını alma ve geçti mi kaldı mı durumunu öğrenme
                if (studentExamAvg[i]>=50 )
                {
                    Console.WriteLine($"{studentnames[i]} adlı öğrenci dersi geçti : ");
                }
                else
                {
                    Console.WriteLine($"{studentnames[i]} adlı öğrenci dersten kaldı : ");
                }
                Console.WriteLine("--------------------------------------");
            }

            #endregion
            Console.ReadKey();
        
        }

    }
}
