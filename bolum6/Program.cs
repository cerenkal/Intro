using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum6
{
//    6 DÖNGÜ YAPISI
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
// Aritmetik işlem operatörleri(+, -, *, /, %)
// Karşılaştırma operatörleri(<, >, <=, >=, ==, !=)
// Mantıksal operatörler(&&, ||, !)
// Karar yapıları(if, if-else, switch-case)
// Döngü yapıları(while, do-while)
// Pratik atama operatörleri(+=, -=, *=, /=, ++, --)
//6.1 SAYI KARŞILAŞTIRMA ÖRNEKLERİ
//6.1.1 Girilen 10 sayıdan en küçük/büyük olanı tespit etme
//Kullanıcıdan istenecek 10 adet sayının içerisinde en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin.Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır.Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
//Programı geliştirirken minimum sayıda değişken kullanın, her giriş yapılan değer için değişken oluşturmayın.Ayrıca kodlamada dizi kullanılmayacaktır.
//Program bir kez hesap yaptıktan sonra herhangi bir tuşa basıldığında sonlanacaktır.
//6.1.2 Girilen belirsiz miktardaki sayıdan en küçük/büyük olanı tespit etme
//Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit edip ekrana sonucu yazan programı geliştirin.Kullanıcıdan toplamda kaç adet sayı alınacağı kullanıcıya
//bağlı olacak, kullanıcı “end” yazdığında sayı alma işlemi durdurulacak ve sonuçlar ekrana yazdırılacak.Ancak kullanıcı minimum 2 sayı yazmak zorundadır.Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
//Programı geliştirirken minimum sayıda değişken kullanın, her giriş yapılan değer için değişken oluşturmayın.Ayrıca kodlamada dizi kullanılmayacaktır.
//Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir. Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.
//NOT: “end” komutu, eğer ki toplamda 2 sayıya ulaşılmadıysa işlevsiz olacaktır ve uyarı döndürecektir.Ancak “exit” komutu herhangi bir anda doğrudan çalışabilir. Ayrıca kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
//6.2 DÖNGÜ İÇERİSİNDE HESAPLAMA ÖRNEKLERİ
//6.2.1 Girilen aralıktaki sayıların kare ve küp hesapları
//Kullanıcıdan alınacak iki sayı arasında kalan tüm sayıların kare ve küp değerleri hesaplanacaktır.Kullanıcı iki sayıyı birincisi küçük, ikincisi büyük olacak şekilde veya birincisi büyük, ikincisi küçük olacak şekilde sıraya bağlı kalmaksızın girebilir.
//Kullanıcının yazdığı değerlerin sayı olup olmadığının kontrolü yapılmalıdır. Kullanıcı uygun formatta sayı yazmazsa (“Yirmibeş”, “üç”, “Muhittin”) uyarı döndürülecek ve girilen değer geçersiz sayılacaktır.
//Yapılan hesaplamalar ekrana üç kolonlu yapıda yazdırılacaktır: Sayı {TAB
//}
//Karesi
//{ TAB}
//Küpü
//Program hesaplama ve tespit işlemlerini yaptıktan sonra başa dönecek ve tekrar sayı girişi bekleyecektir. Programı sonlandırmak, kullanıcının “exit” yazmasına bağlı olacaktır.
    class Program
    {
        static void Main(string[] args)
        {
            #region 6.1.1

            //int sayac = 0;
            //int sayi;
            //string msg = "Yimibeş"+" "+" "+"üç"+" "+" "+"Muhittin";
            //int maxSayi = 0;
            //int minSayi=100;
            //do
            //{

            //    try
            //    {
            //        Console.WriteLine("sayı giriniz: ");
            //        sayi = Int32.Parse(Console.ReadLine());
            //        if (sayi>maxSayi)
            //        {
            //            maxSayi = sayi;

            //        }
            //        if (minSayi>sayi)
            //        {
            //            minSayi = sayi;
            //        }
            //        sayac++;

            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine(msg);

            //    }

            //} while (sayac < 10);
            //Console.WriteLine($"en büyük sayı = {maxSayi}");
            //Console.WriteLine($"en küçük sayı = {minSayi}");
            //Console.ReadLine();

            #endregion

            #region 6.1.2

            //int sayac = 0;
            //int sayi;
            //string msg = "Yimibeş" + " " + " " + "üç" + " " + " " + "Muhittin";
            //int maxSayi = 0;
            //int minSayi = 100;
            //string soru1 = string.Empty;
            //string soru2 = string.Empty;

            //do
            //{
            //    do
            //    {
            //        try
            //        {
            //            Console.WriteLine("sayı giriniz: ");
            //            sayi = Int32.Parse(Console.ReadLine());
            //            if (sayi > maxSayi)
            //            {
            //                maxSayi = sayi;
            //            }
            //            if (minSayi > sayi)
            //            { 
            //                minSayi = sayi;
            //            }
            //            sayac++;
            //        }
            //        catch (FormatException ex)
            //        {
            //            Console.WriteLine(msg);

            //        }
            //        Console.WriteLine("bitirmek istiyorsanız end yazın? : ");
            //        soru1 = Console.ReadLine();

            //    } while ((sayac != 2 || soru1 != "end") && (sayac<2 || soru1 != "end") );
            //    Console.WriteLine($"en büyük sayı = {maxSayi}");
            //    Console.WriteLine($"en küçük sayı = {minSayi}");
            //    Console.WriteLine($"{sayac} adet sayı girişi yapılmıştır");

            //    Console.WriteLine("işlemleri bitirmek istiyorsanız exit yazın? : ");
            //    soru2 = Console.ReadLine();

            //} while (soru2 != "exit" );

            //Console.ReadLine();

            #endregion

            #region 6.2.1

            int sayac = 0;
            int sayi1, sayi2;
            string msg = "Yimibeş" + " " + " " + "üç" + " " + " " + "Muhittin";
            int maxSayi = 0;
            int minSayi = 100;
            int karesi, kupu;
            bool sayiMi1 = true;
            bool sayiMi2 = true;
            string soru = string.Empty;

            do
            {
                Console.WriteLine("birinci sayıyı giriniz: ");
                sayiMi1 = Int32.TryParse(Console.ReadLine(), out sayi1);

                Console.WriteLine("ikinci sayıyı giriniz: ");
                sayiMi2 = Int32.TryParse(Console.ReadLine(), out sayi2);
                if (sayiMi1==false)
                {
                    Console.WriteLine(msg);
                   
                }
                if (sayiMi2 == false)
                {
                    Console.WriteLine(msg);

                }


            } while (sayiMi1!=true || sayiMi2!=true);

            
                maxSayi = sayi1;

                if (sayi2 > maxSayi)
                {
                    maxSayi = sayi2;
                    minSayi = sayi1;
                }
                else
                {
                    maxSayi = sayi1;
                    minSayi = sayi2;
                }
                Console.WriteLine($"en büyük sayı = {maxSayi}");
                Console.WriteLine($"en küçük sayı = {minSayi}");
            
                
           
            do
            {
                do
                {

                   karesi = maxSayi * maxSayi;
                   kupu = maxSayi * maxSayi * maxSayi;
                   Console.WriteLine($"sayı : {maxSayi} 'nın karesi = {karesi} ve küpü = {kupu} ");
                   maxSayi--;
                   sayac++;

                } while (maxSayi != minSayi);
                
                Console.WriteLine($"{sayac} adet sayı işleme alınmıştır");
                

                Console.WriteLine("işlemleri bitirmek istiyorsanız exit yazın? : ");
                soru = Console.ReadLine();

            } while (soru != "exit");

            Console.ReadLine();

            #endregion

        }
    }
}
