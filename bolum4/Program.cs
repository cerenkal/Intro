using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum4
{
//    4 MANTIKSAL İŞLEMLER VE OPERATÖRLERİ
//Kullanılabilecek Bilgi ve Teknolojiler
// Console input/output
// Değişkenler
// Aritmetik işlem operatörleri(+, -, *, /, %)
// Karşılaştırma operatörleri(<, >, <=, >=, ==, !=)
// Mantıksal operatörler(&&, ||, !)
//4.1 EKRANDAN GİRİLEN DEĞERLERİ KARŞILAŞTIRMA
//4.1.1 Sayı karşılaştırma
//Ekrandan giriş yapılacak üç sayının karşılaştırması yapılacak.Yapılan karşılaştırmalar bool tipinde değişkenlere atanacak ve sonuçlar ekrana yazdırılacak.
//4.1.2 Yaş karşılaştırma
//Ekrandan giriş yapılacak üç isim ve yaşlarının karşılaştırması yapılacak.Yapılan karşılaştırmalar bool tipinde değişkenlere atanacak ve sonuçlar ekrana yazdırılacak.
//Sonuçlar aşağıdaki gibi çıktı üretmelidir: ÖRNEK01: Programda 45, 3, 100 sayılarının giriş yapıldığını düşünelim: 01. 45, 3 ve 100 sayıları birbirine eşittir: false 02. 45, 3 ve 100 sayıları birbirine eşit değildir: true 03. 45 sayısı 3 ve 100 sayılarından büyüktür: false 04. 45 sayısı 3 ve 100 sayılarından büyüktür veya sayılara eşittir: false 05. 45 sayısı 3 ve 100 sayılarından küçüktür: false 06. 45 sayısı 3 ve 100 sayılarından küçüktür veya sayılara eşittir: false 07. 3 sayısı 45 ve 100 sayılarından büyüktür: false 08. 3 sayısı 45 ve 100 sayılarından büyüktür veya sayılara eşittir: false 09. 3 sayısı 45 ve 100 sayılarından küçüktür: true 10. 3 sayısı 45 ve 100 sayılarından küçüktür veya sayılara eşittir: true 11. 100 sayısı 45 ve 3 sayılarından büyüktür: true 12. 100 sayısı 45 ve 3 sayılarından büyüktür veya sayılara eşittir: true 13. 100 sayısı 45 ve 3 sayılarından küçüktür: false 14. 100 sayısı 45 ve 3 sayılarından küçüktür veya sayılara eşittir: false ÖRNEK02: Programda Tsubasa 17, Misaki 15 ve Hyuga 21 değerlerinin giriş yapıldığını düşünelim: 01. Tsubasa, Misaki ve Hyuga isimli kişilerin yaşları birbirine eşittir: false 02. Tsubasa, Misaki ve Hyuga isimli kişilerin yaşları birbirine eşit değildir: true 03. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından büyüktür: false 04. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: false
//05. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından küçüktür: false 06. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: false 07. Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından büyüktür: false 08. Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: false 09. Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından küçüktür: true 10. Misaki isimli kişinin yaşı Tsubasa ve Hyuga isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: true 11. Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından büyüktür: true 12. Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: true 13. Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından küçüktür: false 14. Hyuga isimli kişinin yaşı Tsubasa ve Misaki isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: false
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Giriş1: ");
            //int number1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Giriş2: ");
            //int number2 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Giriş3: ");
            //int number3 = Int32.Parse(Console.ReadLine());

            //bool isEqual = number1 == number2 && number2 == number3;
            //bool isNotEqual = number1 != number2 || number2 != number3 || number1 != number3;
            //bool isGreater = number1 > number2 && number1 > number3;
            //bool isGreater2 = number2 > number1 && number2 > number3;
            //bool isGreater3 = number3 > number1 && number3 > number2;
            //bool isLess = number1 < number2 && number1 < number3;
            //bool isLess2 = number2 < number1 && number2 < number3;
            //bool isLess3 = number3 < number2 && number3 < number1;
            //bool isGreaterAndEqual = number1 >= number2 || number1 >= number3;
            //bool isGreaterAndEqual2 = number2 >= number1 || number2 >= number3;
            //bool isGreaterAndEqual3 = number3 >= number2 || number3 >= number1;
            //bool isLessAndEqual = number1 <= number2 || number1<=number3 ;
            //bool isLessAndEqual2 = number2 <= number1 || number2 <= number3;
            //bool isLessAndEqual3 = number3 <= number2 || number3 <= number1;

            //Console.WriteLine("Giriş1=Giriş2=Giriş3 değerine eşit midir?: ");
            //Console.WriteLine(isEqual);

            //Console.WriteLine("Giriş1!=Giriş2, Giriş1!=Giriş2, Giriş2!=Giriş3 değerine eşit değil midir?: ");
            //Console.WriteLine(isNotEqual);

            //Console.WriteLine("Giriş1'in değeri Giriş2 ve Giriş3 den değerinden büyük müdür?: ");
            //Console.WriteLine(isGreater);

            //Console.WriteLine("Giriş2'in değeri Giriş1 ve Giriş3 değerinden büyük müdür?: ");
            //Console.WriteLine(isGreater2);

            //Console.WriteLine("Giriş3'in değeri Giriş1 ve Giriş2 değerinden büyük müdür?: ");
            //Console.WriteLine(isGreater3);

            //Console.WriteLine("Giriş1'in değeri Giriş2 ve Giriş3 değerinden küçük müdür?: ");
            //Console.WriteLine(isLess);

            //Console.WriteLine("Giriş2'in değeri Giriş1 ve Giriş3 değerinden küçük müdür?: ");
            //Console.WriteLine(isLess2);

            //Console.WriteLine("Giriş3'in değeri Giriş1 ve Giriş2 değerinden küçük müdür?: ");
            //Console.WriteLine(isLess3);

            //Console.WriteLine("Giriş1'in değeri Giriş2 ve Giriş3 değerine büyük eşit midir?: ");
            //Console.WriteLine(isGreaterAndEqual);

            //Console.WriteLine("Giriş2'in değeri Giriş1 ve Giriş3 değerine büyük eşit midir?: ");
            //Console.WriteLine(isGreaterAndEqual2);

            //Console.WriteLine("Giriş3'in değeri Giriş1 ve Giriş2 değerine büyük eşit midir?: ");
            //Console.WriteLine(isGreaterAndEqual3);

            //Console.WriteLine("Giriş1'in değeri Giriş2 ve Giriş3 değerine küçük eşit midir?: ");
            //Console.WriteLine(isLessAndEqual);

            //Console.WriteLine("Giriş2'in değeri Giriş1 ve Giriş3 değerine küçük eşit midir?: ");
            //Console.WriteLine(isLessAndEqual2);

            //Console.WriteLine("Giriş3'in değeri Giriş1 ve Giriş2 değerine küçük eşit midir?: ");
            //Console.WriteLine(isLessAndEqual3);

            //Console.ReadLine();

            #region 4.1.2

            Console.WriteLine("isim1: ");
            string isim1 = Console.ReadLine();

            Console.WriteLine("isim2: ");
            string isim2 = Console.ReadLine();
            
            Console.WriteLine("isim3: ");
            string isim3 = Console.ReadLine();

            bool isEqual = isim1 == isim2 && isim1==isim3;
            bool isNotEqual = isim1 != isim2 || isim1!=isim3 || isim2==isim3;

            Console.WriteLine("isim1= isim2= isim3 birbirlerine eşit midir?: ");
            Console.WriteLine(isEqual);
            Console.WriteLine("isim1, isim2, isim3 birbirlerine eşit değil midir?: ");
            Console.WriteLine(isNotEqual);


            Console.WriteLine("Yaş1: ");
            int yas1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Yaş2: ");
            int yas2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Yaş3: ");
            int yas3 = Int32.Parse(Console.ReadLine());

            bool isEqual1 = yas1 == yas2 && yas2 == yas3;
            bool isNotEqual1 = yas1 != yas2 || yas2 != yas3 || yas1 != yas3;
            bool isGreater = yas1 > yas2 && yas1 > yas3;
            bool isGreater2 = yas2 > yas1 && yas2 > yas3;
            bool isGreater3 = yas3 > yas1 && yas3 > yas2;
            bool isLess = yas1 < yas2 && yas1 < yas3;
            bool isLess2 = yas2 < yas1 && yas2 < yas3;
            bool isLess3 = yas3 < yas2 && yas3 < yas1;
            bool isGreaterAndEqual = yas1 >= yas2 || yas1 >= yas3;
            bool isGreaterAndEqual2 = yas2 >= yas1 || yas2 >= yas3;
            bool isGreaterAndEqual3 = yas3 >= yas2 || yas3 >= yas1;
            bool isLessAndEqual = yas1 <= yas2 || yas1 <= yas3;
            bool isLessAndEqual2 = yas2 <= yas1 || yas2 <= yas3;
            bool isLessAndEqual3 = yas3 <= yas2 || yas3 <= yas1;

            Console.WriteLine("Yaş1=Yaş2=Yaş3 değerine eşit midir?: ");
            Console.WriteLine(isEqual1);

            Console.WriteLine("Yaş1!=Yaş2, Yaş1!=Yaş2, Yaş2!=Yaş3 değerine eşit değil midir?: ");
            Console.WriteLine(isNotEqual1);

            Console.WriteLine("Yaş1'in değeri Yaş2 ve Yaş3 den değerinden büyük müdür?: ");
            Console.WriteLine(isGreater);

            Console.WriteLine("Yaş2'in değeri Yaş1 ve Yaş3 değerinden büyük müdür?: ");
            Console.WriteLine(isGreater2);

            Console.WriteLine("Yaş3'in değeri Yaş1 ve Yaş2 değerinden büyük müdür?: ");
            Console.WriteLine(isGreater3);

            Console.WriteLine("Yaş1'in değeri Yaş2 ve Yaş3 değerinden küçük müdür?: ");
            Console.WriteLine(isLess);

            Console.WriteLine("Yaş2'in değeri Yaş1 ve Yaş3 değerinden küçük müdür?: ");
            Console.WriteLine(isLess2);

            Console.WriteLine("Yaş3'in değeri Yaş1 ve Yaş2 değerinden küçük müdür?: ");
            Console.WriteLine(isLess3);

            Console.WriteLine("Yaş1'in değeri Yaş2 ve Yaş3 değerine büyük eşit midir?: ");
            Console.WriteLine(isGreaterAndEqual);

            Console.WriteLine("Yaş2'in değeri Yaş1 ve Yaş3 değerine büyük eşit midir?: ");
            Console.WriteLine(isGreaterAndEqual2);

            Console.WriteLine("Yaş3'in değeri Yaş1 ve Yaş2 değerine büyük eşit midir?: ");
            Console.WriteLine(isGreaterAndEqual3);

            Console.WriteLine("Yaş1'in değeri Yaş2 ve Yaş3 değerine küçük eşit midir?: ");
            Console.WriteLine(isLessAndEqual);

            Console.WriteLine("Yaş2'in değeri Yaş1 ve Yaş3 değerine küçük eşit midir?: ");
            Console.WriteLine(isLessAndEqual2);

            Console.WriteLine("Yaş3'in değeri Yaş1 ve Yaş2 değerine küçük eşit midir?: ");
            Console.WriteLine(isLessAndEqual3);

            
            Console.ReadLine();

            #endregion
        }
    }
}
