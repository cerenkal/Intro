using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum2
{
//    2 ARİTMETİK İŞLEMLER VE OPERATÖRLERİ
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
// Aritmetik işlem operatörleri(+, -, *, /, %)
//2.1 TEMEL ARİTMETİK İŞLEMLER
//2.1.1 Ekrandan okunan iki tamsayının toplamı
//Ekrandan sırasıyla okunacak iki değer öncelikle int (veya uygun olabilecek diğer bir tamsayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak int tipinde bir toplam değişkenine iki sayının toplamı alınarak atama işlemi yapılır. Sonuç ekrana yazdırılır.
//2.1.2 Ekrandan okunan iki tamsayının farkı
//Ekrandan sırasıyla okunacak iki değer öncelikle int (veya uygun olabilecek diğer bir tamsayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak int tipinde bir fark değişkenine iki sayının farkı alınarak atama işlemi yapılır. Sonuç ekrana yazdırılır.
//2.1.3 Ekrandan okunan iki tamsayının çarpımı
//Ekrandan sırasıyla okunacak iki değer öncelikle int (veya uygun olabilecek diğer bir tamsayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak int tipinde bir çarpım değişkenine iki sayının çarpımı alınarak atama işlemi yapılır. Sonuç ekrana yazdırılır.
//2.1.4 Ekrandan okunan iki tamsayının bölümü
//Ekrandan sırasıyla okunacak iki değer öncelikle int (veya uygun olabilecek diğer bir tamsayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak int tipinde bir bölüm değişkenine iki sayının bölümü hesaplatılarak atama işlemi yapılır. Sonuç ekrana yazdırılır.Bu örnekte dikkat edilmesi gereken nokta; bir sayının sıfır değerine bölünmesi yazılımda büyük hatalardan biridir.Ayrıca dikkat edilmesi gereken diğer nokta, tamsayı bölüm işlem sonucu normalde ondalık bir sonuç üretiyor olsa bile tamsayı olarak elde edilmektedir.
//2.1.5 Ekrandan okunan iki ondalık sayı üzerinde 4 işlem hesapları
//Ekrandan sırasıyla okunacak iki değer öncelikle float (veya uygun olabilecek diğer bir ondalık sayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak float tipinde bir sonuç değişkenine, iki sayının 4 işlem hesapları yapıldıktan sonra atama işlemi gerçekleştirilir.Sonuç ekrana yazdırılır.Ondalık sayılar ile yapılacak 4 işlem hesaplarında dikkat edilmesi gereken nokta; tüm değişkenlerin ondalık sayı tipinde olması gerekliliğidir.
//2.2 DÖNÜŞÜM GEREKTİREN ARİTMETİK İŞLEMLER
//2.2.1 Ekrandan okunan bir tamsayı ve bir ondalık sayı üzerinde 4 işlem hesapları
//Ekrandan sırasıyla okunacak iki değer uygun sırada biri int (veya diğer bir tamsayı) diğeri float (veya diğer bir ondalık sayı) tipine dönüştürülerek değişkenlerde tutulur.Üçüncü olarak tanımlanacak float tipinde bir sonuç değişkenine, iki sayının 4 işlem hesapları yapıldıktan sonra atama işlemi gerçekleştirilir.Sonuç ekrana yazdırılır.Bir tamsayı ve bir ondalık sayı kullanılarak yapılacak 4 işlem hesaplarında dikkat edilmesi gereken nokta; tamsayı değişkenler işlem içerisinde ondalık sayı tipine açık dönüşüm(explicit cast) yapılarak dönüştürülmesi gereklidir.
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.1.1
            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //int sonuc = sayi1 + sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();
            #endregion

            #region 2.1.2
            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //int sonuc = sayi1 - sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();
            #endregion

            #region 2.1.3
            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("sayı girişi yapınız: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //int sonuc = sayi1 * sayi2;

            //Console.WriteLine(sonuc);
            //Console.ReadLine();
            #endregion

            #region 2.1.4
            // Console.WriteLine("sayı girişi yapınız: ");
            // int sayi1 = Int32.Parse(Console.ReadLine());

            //geriDon: Console.WriteLine("sayı girişi yapınız: ");
            // int sayi2 = Int32.Parse(Console.ReadLine());
            // if (sayi2 != 0)
            // {
            //     int sonuc = sayi1 / sayi2;
            //     Console.WriteLine(sonuc);
            // }
            // else
            // {
            //     Console.WriteLine("hatalı giriş yaptınız");
            //     goto geriDon;
            // }
            // Console.ReadLine();
            #endregion
            #region 2.1.5
           // Console.WriteLine("sayı girişi yapınız: ");
           // float sayi1 = float.Parse(Console.ReadLine());

           //geriDon: Console.WriteLine("sayı girişi yapınız: ");
           // float sayi2 = float.Parse(Console.ReadLine());

           // float sonuc = sayi1 + sayi2;
           // float sonuc1 = sayi1 - sayi2;
           // float sonuc2 = sayi1 * sayi2;
           // if (sayi2 != 0)
           // {
           //     float sonuc3 = sayi1 / sayi2;
           //     Console.WriteLine($"bölümün sonucu = {sonuc3}");
           // }
           // else
           // {
           //     Console.WriteLine("hatalı giriş yaptınız");
           //     goto geriDon;
           // }
           // Console.WriteLine($"Toplamın sonucu= {sonuc}");
           // Console.WriteLine($"Çıkartmanın sonucu= {sonuc1}");
           // Console.WriteLine($"Çarpımın sonucu= {sonuc2}");

           // Console.ReadLine();
            #endregion

            #region 2.2.1
            Console.WriteLine("sayı girişi yapınız: ");
            int sayi1 = int.Parse(Console.ReadLine());

        geriDon: Console.WriteLine("sayı girişi yapınız: ");
            double sayi2 = double.Parse(Console.ReadLine());

            double sonuc = sayi1 + (int)sayi2;
            double sonuc1 = sayi1 - (int)sayi2;
            double sonuc2 = sayi1 * (int)sayi2;
            if (sayi2 != 0)
            {
                double sonuc3 = sayi1 / (int)sayi2;
                Console.WriteLine($"bölümün sonucu = {sonuc3}");
            }
            else
            {
                Console.WriteLine("hatalı giriş yaptınız");
                goto geriDon;
            }
            Console.WriteLine($"Toplamın sonucu= {sonuc}");
            Console.WriteLine($"Çıkartmanın sonucu= {sonuc1}");
            Console.WriteLine($"Çarpımın sonucu= {sonuc2}");

            Console.ReadLine();


            #endregion
        }
    }
}
