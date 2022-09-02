using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum8._2
{
//    8.2 PALİNDROME
//Tersten ve düzden okunduğunda aynı okunan cümlelere, sözcüklere veya sayılara palindrom denir.Örneğin İLAÇ İÇ ALİ cümlesi, AĞA, NAZAN, KÜÇÜK sözcükleri ve 363, 2442, 98789 sayıları birer palindromdur.Kullanıcının ekrandan gireceği tam sayının bir palindrom olup olmadığını kontrol eden ve sonucu ekrana yazdıran bir program yazınız.
//Girilen ifadenin doğru bir tamsayı olup olmadığı kontrol edilmelidir.Eğer ki kullanıcının giriş yaptığı değer bir tamsayı değilse, kullanıcıdan doğru formatta bir sayı istenmelidir. Ayrıca yapılacak işlemler kesinlikle tamsayı tipindeki değişkenler kullanılarak yapılmalıdır.Bu örnekte string metotları kullanılmayacaktır.
//Programı sonlandırmak için sayı giriş aşamasında “exit” yazılması gereklidir.
//Program örnek çıktısı aşağıdaki gibidir:
//Bir tamsayı yazınız: yirmibeş
//Lütfen doğru formatta bir sayı yazınız!
//Bir tamsayı yazınız: 25
//Girdiğiniz sayı bir palindrom değildir.
//Bir tamsayı yazınız: 545
//Girdiğiniz sayı bir palindromdur.
//Bir tamsayı giriniz: 9449
//Girdiğiniz sayı bir palindromdur.
//Bir tamsayı giriniz: exit
    class Program
    {

        static void Main(string[] args)
        {

            PalindromeMu(SayiAl());
            Console.ReadLine();

        }
        static int SayiAl()
        {

            bool sayiMi = true;
            int sayi;
            string sonlandirma;
            do
            {
                Console.WriteLine("sayı girişi yapınız: ");
                sayiMi = int.TryParse(Console.ReadLine(), out sayi);
                if (sayiMi == false || sayi == 0)
                {
                    Console.WriteLine("yanlış formatta giriş yaptınız tekrar deneyin");
                }
                
                Console.WriteLine("sayı girişini sonlandırmak istiyorsanız exit yazınız ");
                sonlandirma = Console.ReadLine();

            } while (sonlandirma != "exit");

            return sayi;
        }
        static void PalindromeMu(int a)
        {
            int[] palindromeDizi = new int[0];


            if (a % 10 != 0 || a != 0)
            {
                int birler = a % 10;
                Array.Resize(ref palindromeDizi, palindromeDizi.Length + 1);
                palindromeDizi[0] = birler;

                if (a / 10 > 0)
                {
                    int onlar = (a / 10) % 10;
                    Array.Resize(ref palindromeDizi, palindromeDizi.Length + 1);
                    palindromeDizi[1] = onlar;

                    if (a / 100 > 0)
                    {
                        int yuzler = (a / 100) % 10;
                        Array.Resize(ref palindromeDizi, palindromeDizi.Length + 1);
                        palindromeDizi[2] = yuzler;

                        if (a / 1000 > 0)
                        {
                            int binler = a / 1000;
                            Array.Resize(ref palindromeDizi, palindromeDizi.Length + 1);
                            palindromeDizi[3] = binler;

                            if (a / 10000 > 0)
                            {
                                int onbinler = a / 10000;
                                Array.Resize(ref palindromeDizi, palindromeDizi.Length + 1);
                                palindromeDizi[4] = onlar;
                            }
                        }
                    }
                }
            }
            foreach (int item in palindromeDizi)
            {
                Console.Write(item + "-");
            }
            Console.WriteLine("\n");


            for (int i = 0; i < (palindromeDizi.Length) / 2; i++)
            {
                if (palindromeDizi[(palindromeDizi.Length - 1) - i] == palindromeDizi[i])
                {
                    Console.WriteLine("girilen sayı palindromedur");
                }
                else
                {
                    Console.WriteLine("girilen sayı palindrome değildir");
                }
            }
        }
    }
}



