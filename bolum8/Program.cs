using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum8
{
//    8.1 SAYI ÇÖZÜMLEME
//Bir tamsayı alan ve tamsayı basamaklarını çözümleyen bir program yazınız.
//Girilen ifadenin doğru bir tamsayı olup olmadığı kontrol edilmelidir. Eğer ki kullanıcının giriş yaptığı değer bir tamsayı değilse, kullanıcıdan doğru formatta bir sayı istenmelidir. Ayrıca yapılacak işlemler kesinlikle tamsayı tipindeki değişkenler kullanılarak yapılmalıdır.Bu örnekte string metotları kullanılmayacaktır.
//Programı sonlandırmak için sayı giriş aşamasında “exit” yazılması gereklidir.
//2837 sayısı için sonuç aşağıdaki gibi görünmelidir:
//7 x 1 = 7
//3 x 10 = 30
//8 x 100 = 800
//2 x 1000 = 2000
    class Program
    {
        static void Main(string[] args)
        {
            Basamaklar(SayiAl());
            Console.ReadLine();
        }

        static int SayiAl()
        {
            bool sayiMi = true;
            int sayi;
            string sonlandirma;
            do
            {
            geriDon: Console.WriteLine("sayı girişi yapınız: ");
                sayiMi = int.TryParse(Console.ReadLine(), out sayi);
                if (sayi == 0)
                {
                    Console.WriteLine("yanlış formatta giriş yaptınız tekrar deneyin");
                    goto geriDon;
                }
                if (sayiMi == false)
                {
                    Console.WriteLine("yanlış formatta giriş yaptınız tekrar deneyin");
                    goto geriDon;
                }
                Console.WriteLine("sayı girişini sonlandırmak istiyorsanız exit yazınız ");
                sonlandirma = Console.ReadLine();

            } while (sonlandirma!="exit");
        
            return sayi;
        }

        static void Basamaklar(int a)
        {
            if (a % 10 != 0)
            {
                int birler = a % 10;

                int sonuc1 = birler * 1;
                Console.WriteLine($"{birler} x 1 = {sonuc1}");
               
                if (a / 10 > 0)
                {
                    int onlar = (a / 10) % 10;

                    int sonuc2 = onlar * 10;
                    Console.WriteLine($"{onlar} x 10 = {sonuc2}");
                   
                    if (a / 100 > 0)
                    {
                        int yuzler = (a / 100) % 10;

                        int sonuc3 = yuzler * 100;
                        Console.WriteLine($"{yuzler} x 100 = {sonuc3}");
                       
                        if (a / 1000 > 0)
                        {
                            int binler = a / 1000;

                            int sonuc4 = binler * 1000;
                            Console.WriteLine($"{binler} x 1000 = {sonuc4}");
                        }
                    }
                }
            }
        }
    }
}
