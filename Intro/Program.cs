using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
//    1 DEĞİŞKENLER
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
//1.1 EKRANDAN GİRİŞ YAPILAN DEĞERİN DEĞİŞKENE ATANMASI
//1.1.1 Ekrandan girilen değerin string bir değişkene atanması
//Bu örnekte string tipinde bir değişken oluşturularak basitçe Console.ReadLine() metodundan dönen değer string bir değişkene atanır.Atamanın doğruluğu kontrol edilmesi için Console.WriteLine() kullanılarak “Klavyeden girdiğiniz değer string değişken” şeklinde değişkenin değeri ekrana yazdırılır.
//1.1.2 Ekrandan girilen değerin tamsayı tipinde bir değişkene atanması
//Bu örnekte tip dönüşümü konusuna giriş yapılır.Konsol ekranından giriş yapılan değer öncelikle Console.ReadLine() metodu kullanılarak string tipinde bir değişkene atanır.Sonra Int32 tipinde yeni bir değişken tanımlanarak int.Parse() metodu yardımıyla string değer integer değere dönüştürülür.Integer değişken Console.WriteLine() metodu kullanılarak ekrana yazdırılır.Aynı örnek byte, short veya long değişkenleri ile de uygulanabilir, farkları anlatılır. (Convert sınıfı OOP konularına kadar kullanılmaz)
//1.1.3 Ekrandan girilen değerin ondalık sayı tipinde değişkene atanması
//Bu örnekte tip dönüşümü konusunda yeni bir uygulama yapılır.Konsol ekranından giriş yapılan değer öncelikle Console.ReadLine() metodu kullanılarak string tipinde bir değişkene atanır.Sonra Float tipinde bir değişken tanımlanarak float.Parse() metodu yardımıyla string değer float tipinde değere dönüştürülür.Float tipindeki değişkenin değeri Console.WriteLine() metodu yardımıyla ekrana yazdırılır.Aynı örnek double ve decimal tipleri için de uygulanabilir, farklar anlatılır. (Convert sınıfı OOP konularına kadar kullanılmaz)
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.1.1

            Console.WriteLine("bir değer giriniz:");
            string a = Console.ReadLine();
            Console.WriteLine("klavyeden girdiğiniz değer string değişkendir");
            Console.ReadLine();

            #endregion

            #region 1.1.2

            Console.WriteLine("bir değer giriniz: ");
            int deger = Int32.Parse(Console.ReadLine());
            Console.WriteLine("bir değer giriniz: ");
            short deger1 = short.Parse(Console.ReadLine());
            Console.WriteLine(deger);
            Console.WriteLine(deger1);
            Console.ReadLine();

            #endregion
            #region 1.1.3

            Console.WriteLine("bir sayı giriniz: ");
            string c = Console.ReadLine();
            float d = float.Parse(c);
            Console.WriteLine("bir sayı giriniz: ");
            string e = Console.ReadLine();
            decimal f = decimal.Parse(e);
            Console.WriteLine("bir sayı giriniz: ");
            string j = Console.ReadLine();
            double k = double.Parse(j);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(k);
            Console.ReadLine();

            #endregion
        }
    }
}
