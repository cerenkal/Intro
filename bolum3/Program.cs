using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum3
{
//    3 KARŞILAŞTIRMA İŞLEMLERİ VE OPERATÖRLERİ
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
// Aritmetik işlem operatörleri(+, -, *, /, %)
// Karşılaştırma operatörleri(<, >, <=, >=, ==, !=)
//Karar yapılarına geçmeden önce karşılaştırma işlemleri ve operatörleri üzerinde bazı örnekler yapılabilir.Boolean tipinde tanımlanacak bir değişkene, yapılacak karşılaştırma işlemlerinin sonucu atanarak ekrana yansıtılabilir.
//Karar yapılarını kullanmadan yapılacak örneklerde, öğrenciler “karşılaştırma işlemlerinin” aritmetik işlemlerde olduğu gibi bir “işlem” olduğunu ve sonuç ürettiğini, üretilen sonucun da bir değişkende tutulabildiğini kavramaktadır.
//3.1 EKRANDAN GİRİLEN DEĞERLERİ KARŞILAŞTIRMA
//3.1.1 Ekrandan okunan iki string ifadeyi karşılaştırma
//Kullanıcıdan alınacak iki giriş iki ayrı string tipinde değişkende tutulur. İki değişken değeri sırasıyla “eşittir” ve “eşit değildir” operatörleri kullanılarak karşılaştırılır.
//bool isEqual = input1 == input2;
//    bool isNotEqual = input1 != input2;
//    Tüm sonuçlar sırayla ekrana yazdırılır:
//Console.WriteLine(“Giriş1’in değeri Giriş2’nin değerine eşit midir?: ”);
//Console.Write(isEqual);
//Diğer karşılaştırma operatörleri olan büyüktür, büyük veya eşittir, küçüktür ve küçük veya eşittir string tiplerde uygulanamamaktadır.
//3.1.2 Ekrandan okunan iki tam sayıyı karşılaştırma
//Kullanıcıdan alınacak iki tamsayı öncelikle int tipinde iki ayrı değişkende saklanır.İki değişkenin değeri, tüm karşılaştırma operatörleri kullanılarak karşılaştırma işlemi yapılır.Sonuçlar, her karşılaştırma işlemi için ayrı ayrı açılacak Boolean tipinde değişkenlerde tutulur.
//bool isGreater = number1 > number2;
//    bool isEqual = number1 == number2;
//    Tüm sonuçlar ekrana alt alta yazdırılır:
//Console.WriteLine(“Sayı1’in değeri Sayı2’nin değerinden büyük müdür?: ”);
//Console.Write(isGreater);
//3.1.3 Ekrandan okunan iki karakteri karşılaştırma
//Kullanıcıdan alınacak iki karakter öncelikle char tipinde iki ayrı değişkende saklanır.İki değişkenin değeri, tüm karşılaştırma operatörleri kullanılarak karşılaştırma işlemi yapılır.Sonuçlar, her karşılaştırma işlemi için ayrı ayrı açılacak Boolean tipinde değişkenlerde tutulur.
//bool isEqual = char1 == char2;
//    bool isGreater = char1 > char2;
//    Tüm sonuçlar ekrana alt alta yazdırılır:
//Console.WriteLine(“Karakter1 Karakter2’nin değerinden büyük müdür?: ”);
//Console.Write(isGreater);
//Char tipleri üzerinde tüm karşılaştırma operatörleri kullanılabilmektedir.Bu örnekte öğrenci, karakterlerin karşılaştırılabildiğini anlar ve ileride yapılacak kelime sıralama algoritması için altyapı oluşturur.
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.1.1

            //Console.WriteLine("Giriş1: ");
            //string input1 = Console.ReadLine();

            //Console.WriteLine("Giriş2: ");
            //string input2 = Console.ReadLine();

            //bool isEqual = input1 == input2;
            //bool isNotEqual = input1 != input2;

            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine eşit midir?: ");
            //Console.WriteLine(isEqual);
            //Console.ReadLine();

            #endregion

            #region 3.1.2

            //Console.WriteLine("Giriş1: ");
            //int number1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Giriş2: ");
            //int number2 = Int32.Parse(Console.ReadLine());

            //bool isEqual = number1 == number2;
            //bool isNotEqual = number1 != number2;
            //bool isGreater = number1 > number2;
            //bool isGreater2 = number2 > number1;
            //bool isLess = number1 < number2;
            //bool isLess2 = number2 < number1;
            //bool isGreaterAndEqual = number1 >= number2;
            //bool isGreaterAndEqual2 = number2 >= number1;
            //bool isLessAndEqual = number1 <= number2;
            //bool isLessAndEqual2 = number2 <= number1;


            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine eşit midir?: ");
            //Console.WriteLine(isEqual);

           // Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine eşit değil midir?: ");
            //Console.WriteLine(isNotEqual);

            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerinden büyük müdür?: ");
            //Console.WriteLine(isGreater);

            //Console.WriteLine("Giriş2'in değeri Giriş1'nin değerinden büyük müdür?: ");
            //Console.WriteLine(isGreater2);

            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerinden küçük müdür?: ");
            //Console.WriteLine(isLess);

            //Console.WriteLine("Giriş2'in değeri Giriş1'nin değerinden küçük müdür?: ");
            //Console.WriteLine(isLess2);

            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine büyük eşit midir?: ");
            //Console.WriteLine(isGreaterAndEqual);

            //Console.WriteLine("Giriş2'in değeri Giriş1'nin değerine büyük eşit midir?: ");
            //Console.WriteLine(isGreaterAndEqual2);

            //Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine küçük eşit midir?: ");
            //Console.WriteLine(isLessAndEqual);

            //Console.WriteLine("Giriş2'in değeri Giriş1'nin değerine küçük eşit midir?: ");
            //Console.WriteLine(isLessAndEqual2);

            //Console.ReadLine();

            #endregion

            #region 3.1.3

            Console.WriteLine("Giriş1: ");
            char karakter1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Giriş2: ");
            char karakter2 = char.Parse(Console.ReadLine());

            bool isEqual = karakter1 == karakter2;
            bool isNotEqual = karakter1 != karakter2;
            bool isGreater = karakter1 > karakter2;
            bool isGreater2 = karakter2 > karakter1;
            bool isLess = karakter1 < karakter2;
            bool isLess2 = karakter2 < karakter1;
            bool isGreaterAndEqual = karakter1 >= karakter2;
            bool isGreaterAndEqual2 = karakter2 >= karakter1;
            bool isLessAndEqual = karakter1 <= karakter2;
            bool isLessAndEqual2 = karakter2 <= karakter1;


            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine eşit midir?: ");
            Console.WriteLine(isEqual);

            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine eşit değil midir?: ");
            Console.WriteLine(isNotEqual);

            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerinden büyük müdür?: ");
            Console.WriteLine(isGreater);

            Console.WriteLine("Giriş2'in değeri Giriş1'nin değerinden büyük müdür?: ");
            Console.WriteLine(isGreater2);

            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerinden küçük müdür?: ");
            Console.WriteLine(isLess);

            Console.WriteLine("Giriş2'in değeri Giriş1'nin değerinden küçük müdür?: ");
            Console.WriteLine(isLess2);

            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine büyük eşit midir?: ");
            Console.WriteLine(isGreaterAndEqual);

            Console.WriteLine("Giriş2'in değeri Giriş1'nin değerine büyük eşit midir?: ");
            Console.WriteLine(isGreaterAndEqual2);

            Console.WriteLine("Giriş1'in değeri Giriş2'nin değerine küçük eşit midir?: ");
            Console.WriteLine(isLessAndEqual);

            Console.WriteLine("Giriş2'in değeri Giriş1'nin değerine küçük eşit midir?: ");
            Console.WriteLine(isLessAndEqual2);

            Console.ReadLine();

            #endregion
        }
    }
}
