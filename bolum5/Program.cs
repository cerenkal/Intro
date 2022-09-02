using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum5
{
//    5 KARAR YAPISI
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
// Aritmetik işlem operatörleri(+, -, *, /, %)
// Karşılaştırma operatörleri(<, >, <=, >=, ==, !=)
// Mantıksal operatörler(&&, ||, !)
// Karar yapıları(if, if-else, switch-case)
//5.1 GİRİLEN DEĞERLERİ KARŞILAŞTIRMA
//5.1.1 Kullanıcı adı ve parola karşılaştırma
//Kullanıcıdan sırayla alınacak “Kullanıcı adı” ve “Şifre” değerleri birer string değişkene atanır.If-Else yapısı içerisinde girilen değerler olması gereken değerler ile karşılaştırılıp sonuç ekrana yazdırılacak.
//5.1.2 Büyük/küçük sayı tespit etme
//Ekrandan girilecek 3 adet sayıdan en büyüğünü ve/veya en küçüğünü tespit eden program yazın.Sonucu ekrana yazdırın.
//5.2 ELDE EDİLEN SONUÇLARI KARŞILAŞTIRMA
//5.2.1 Tek mi Çift mi?
//Ekrandan girilecek 1 tam sayının tek sayı mı yoksa çift sayı mı olduğunu tespit eden ve sonucu ekrana yazdıran bir program geliştiriniz.
//5.2.2 Tam katı tespit etme
//Ekrandan girilecek 2 tam sayıdan, büyük sayının küçük olanın tam katı olup olmadığını tespit edip ekrana yazdıran bir program geliştiriniz.
//5.3 DETAYLI ÖRNEKLER
//5.3.1 Üçgen midir? (Kenar uzunlukları ile)
//Ekrandan girilecek 3 ondalık sayı değeri ile bir üçgen oluşturup oluşturulamayacağının kararını veren bir program yazın.Girilen değerler bir üçgenin kenar uzunluğu olarak kullanılmalıdır.Sonucu ekrana yazdırın.
//5.3.2 Üçgen midir? (Açı değerleri ile)
//Ekrandan girilecek 3 tam sayı değeri ile bir üçgen oluşturup oluşturulamayacağının kararını veren bir program yazın.Girilen değerler bir üçgenin açı değerleri olarak kullanılmalıdır.Sonucu ekrana yazdırın.
//5.3.3 Dik üçgen midir? (Kenar uzunlukları ile)
//Ekrandan girilecek 3 tam sayı değeri ile bir dik üçgen çizilip çizilemeyeceğinin kararını veren programı yazın.Girilen değerler bir üçgenin kenar uzunlukları olarak kullanılmalıdır.Sonucu ekrana yazdırın.
//5.3.4 Dik üçgen midir? (Açı değerleri ile)
//Ekrandan girilecek 3 tam sayı değeri ile bir dik üçgen çizilip çizilemeyeceğinin kararını veren programı yazın.Girilen değerler bir üçgenin açı değerleri olarak kullanılmalıdır.Sonucu ekrana yazdırın.
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.1.1

            // string kullaniciAdi = "ceren";
            // string kullaniciSifre = "123456";

            //geriDon2: Console.WriteLine("kullanıcı adı giriniz: ");
            // string girilenDeger1 = Console.ReadLine();

            //geriDon1: Console.WriteLine("Şifre giriniz: ");
            // string girilenDeger2 = Console.ReadLine();

            // if (kullaniciAdi == girilenDeger1)
            // {
            //     if (kullaniciSifre==girilenDeger2)
            //     {
            //         Console.WriteLine("giriş başarılıdır");
            //     }
            //     else
            //     {
            //         Console.WriteLine("yanlış şifre girdiniz");
            //         goto geriDon1;
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("yanlış kullanıcı adı girdiniz");
            //     goto geriDon2;
            // }
            // Console.ReadLine();

            #endregion

            #region 5.1.2

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("üçüncü sayıyı giriniz: ");
            //int sayi3 = Int32.Parse(Console.ReadLine());
            //int maxSayi = sayi1;
            //if (sayi1<sayi2)
            //{
            //    if (sayi2 < sayi3)
            //    {
            //        maxSayi = sayi3;
            //        Console.WriteLine($"en büyük sayi= {sayi3}");
            //    }
            //    else
            //    {
            //        maxSayi = sayi2;
            //        Console.WriteLine($"en büyük sayi= {sayi2}");
            //    }
            //}
            //else
            //{
            //    sayi1 = maxSayi;
            //    Console.WriteLine($"en büyük sayi= {sayi1}");
            //}
            //Console.ReadLine();
            #endregion

            #region 5.2.1

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int sayi = Int32.Parse(Console.ReadLine());

            //if (sayi%2==0)
            //    Console.WriteLine($"{sayi} = Çift sayıdır");
            //else
            //    Console.WriteLine($"{sayi} = Tek sayıdır");

            //Console.ReadLine();
            #endregion

            #region 5.2.2

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //int maxSayi = sayi1;

            //if (sayi1 < sayi2 )
            //{
            //    maxSayi = sayi2;
            //    if (maxSayi % sayi1 == 0 && sayi1!=0)
            //    {
            //        Console.WriteLine($"{maxSayi} {sayi1}'in tam katıdır");
            //    }
            //    else
            //        Console.WriteLine($"{maxSayi} {sayi1}'in tam katı değildir");
            //}
            //else if (sayi1>sayi2)
            //{
            //    maxSayi = sayi1;
            //    if (maxSayi % sayi2 == 0 && sayi2!=0)
            //    {
            //        Console.WriteLine($"{maxSayi} {sayi2}'in tam katıdır");
            //    }
            //    else
            //        Console.WriteLine($"{maxSayi} {sayi2}'in tam katı değildir");
            //}
            //Console.ReadLine();
            #endregion

            #region 5.3.1

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //double c = double.Parse(Console.ReadLine());

            //if ((a + b) > c && (a + c) > b && (b + c) > a)
            //    Console.WriteLine("Bu bir üçgendir.");
            //else
            //    Console.WriteLine("Bu bir üçgen değildir.");

            //Console.ReadLine();

            #endregion

            #region 5.3.2

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int a = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int b = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int c = Int32.Parse(Console.ReadLine());

            //if ((a+b+c)==180)
            //    Console.WriteLine("Bu bir üçgendir.");
            //else
            //    Console.WriteLine("Bu bir üçgen değildir.");

            //Console.ReadLine();

            #endregion

            #region 5.3.3

            //Console.WriteLine("birinci sayıyı giriniz: ");
            //int a = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz: ");
            //int b = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("üçüncü sayıyı giriniz: ");
            //int c = Int32.Parse(Console.ReadLine());

            //if ((a + b) > c && (a + c) > b && (b + c) > a)
            //{
            //    if ((a * a == b * b + c * c) || (b * b == c * c + a * a) || (c * c == a * a + b * b))
            //    {
            //        Console.WriteLine("Bu bir dik üçgendir.");
            //    }
            //    else
            //        Console.WriteLine("Bu bir dik üçgen değildir.");
            //}
            //else
            //    Console.WriteLine("Bu bir üçgen değildir.");

            //Console.ReadLine();
            #endregion

            #region 5.3.4

            Console.WriteLine("birinci sayıyı giriniz: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("üçüncü sayıyı giriniz: ");
            int c = Int32.Parse(Console.ReadLine());

            if ((a + b + c) == 180)
            {
                if (a==90 || b==90 || c==90)
                    Console.WriteLine("Bu bir dik üçgendir.");
                else
                    Console.WriteLine("Bu bir dik üçgen değildir.");
            }
            else
                Console.WriteLine("Bu bir üçgen değildir.");

            Console.ReadLine();
            #endregion
        }
    }
}
