using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum8._3
{
//    8.3 OTOPARK ÜCRET HESAPLAMA
//Bu programda bir otoparkın ücretlendirme sistemi geliştirilecektir.Otopark ücretleri araç tipine göre değişkenlik göstermektedir.
//Program ilk açıldığında ekranda kullanıcıya araç tipleri seçeneği gelmelidir:
//1. Otomobil için 1’e basın
//2. Motosiklet için 2’ye basın
//3. Minibüs için 3’e basın
//4. Kamyon (ve diğer ticari araçlar) için 4’e basın
//Kullanıcı bu seçeneklerden birisini seçmelidir.Eğer ki yanlış bir giriş yaptıysa program bunu dikkate almayacak ve seçenekler ekranda kalacaktır.
//Araç tipi seçimi yapıldıktan sonra kullanıcıya saat bilgisi sorulmalıdır.
//Araç kaç saat boyunca park alanında kaldı?
//Kullanıcı saat bilgisini ondalık sayı tipinde girecektir. Eğer ki geçersiz bir giriş yapıldıysa sistem kullanıcıya uyarı döndürür ve saat bilgisi yeniden sorulur.
//Araç kaç saat boyunca park alanında kaldı? Dört
//Lütfen geçerli bir sayı yazınız!
//Araç kaç saat boyunca park alanında kaldı? 4
//Aracın park yerini işgal süresi girildikten sonra hesaplama yapılacaktır.Araçların park yeri tarifesi aşağıdaki gibidir:
// Otomobil
//o 0 – 2 saat: 5TL
//o 2 – 6 saat: 10TL
//o 6 – 12 saat: 20TL
//o 12 – 24 saat: 35TL
//o 24 saat sonrası her ilave gün için (saate bakılmaz): +20TL
// Motosiklet
//o 0 – 2 saat: Ücretsiz
//o 2 – 6 saat: 3TL
//o 6 – 12 saat: 6TL
//o 12 – 24 saat: 12TL
//o 12 – 24 saat: 20TL
//o 24 saat sonrası her ilave gün için (saate bakılmaz): +10TL
// Minibüs
//o 0 – 2 saat: 8TL
//o 2 – 6 saat: 16TL
//o 6 – 12 saat: 32TL
//o 12 – 24 saat: 45TL
//o 24 saat sonrası, her ilave gün için (saate bakılmaz): +25TL
// Kamyon ve ticari araç
//o 0 – 2 saat: 15TL
//o 2 – 6 saat: 30TL
//o 6 – 12 saat: 60TL
//o 12 – 24 saat: 100TL
//o 24 saat sonrası, her ilave gün için (saate bakılmaz): +55TL
//Girilen değere göre ücret hesaplaması yaptırılır ve ekrana yazdırılır
//Ödenmesi gereken tutar 10TL
//Eğer kullanıcı sınırda olan bir tam sayı değeri girerse, ücret alt tarifeden hesaplanacaktır. Örneğin 2 saatlik otopark ücreti 0 – 2 saat aralığındaki tarifeye göre hesaplanacaktır.Ancak ondalık sayı tipindeki bir değer için bir üst tarifeye dahil olur. Örneğin 2.5 saatlik otopark ücreti 2 – 6 saatlik otopark ücret tarifesi üzerinden hesaplanır.
    class Program
    {
        static void Main(string[] args)
        {
            Bilgilendirme();
            Hesaplama(SaatBilgisiAl(), AracTipi());

            Console.ReadLine();

        }
        static void Bilgilendirme()
        {
            Console.WriteLine("***************HOŞGELDİNİZ***************");
            Console.WriteLine("Bu programda araç tipine göre ve Otoparkta kalış süresine göre ücret hesaplandırılacaktır.");
            Console.WriteLine("***************İYİ GÜNLER DİLERİZ***************");
        }
        static string AracTipi()
        {
            string aracTipi = string.Empty;
            do
            {
                Console.WriteLine("Aracınızın tipi nedir? Otomabil=1/ Motorsiklet=2/ Minibüs=3/ Kamyon ve Diğer Araçlar için=4 ü tuşlayınız");
                aracTipi = Console.ReadLine();

            } while (aracTipi != "1" && (aracTipi != "2" && (aracTipi != "3" && aracTipi != "4")));
            return aracTipi;
        }
        static double SaatBilgisiAl()
        {
            double saat;
            bool sayiMi;
            do
            {
                Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
                sayiMi = double.TryParse(Console.ReadLine(), out saat);
                if (sayiMi == false)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                }

            } while (sayiMi != true);
            return saat;
        }
        static void Hesaplama(double saat, string aracTipi)
        {

            int tutar = 0;

            if (aracTipi == "1")
            {
                if (saat < 2)
                {
                    tutar = 5;

                    if (saat > 2 && saat < 6)
                    {
                        tutar = 10;

                        if (saat > 6 && saat < 12)
                        {
                            tutar = 20;

                            if (saat > 12 && saat < 24)
                            {
                                tutar = 35;
                            }

                        }
                    }
                }
                else if (saat > 24)
                {
                    tutar = 35 + (int)(saat / 24) * 20;
                }

                Console.WriteLine($" .... Plakalı Otomobil {saat} saat park süresi için ödenecek tutar {tutar}TL dir");
            }


            if (aracTipi == "2")
            {
                if (saat < 2)
                {
                    tutar = 3;

                    if (saat > 2 && saat < 6)
                    {
                        tutar = 6;

                        if (saat > 6 && saat < 12)
                        {
                            tutar = 12;

                            if (saat > 12 && saat < 24)
                            {
                                tutar = 20;
                            }

                        }

                    }
                }
                else if (saat > 24)
                {
                    tutar = 20 + (int)(saat / 24) * 10;
                }
                Console.WriteLine($" .... Plakalı Motorsiklet {saat} saat park süresi için ödenecek tutar {tutar}TL dir");
            }


            if (aracTipi == "3")
            {
                if (saat < 2)
                {
                    tutar = 8;

                    if (saat > 2 && saat < 6)
                    {
                        tutar = 16;

                        if (saat > 6 && saat < 12)
                        {
                            tutar = 32;

                            if (saat > 12 && saat < 24)
                            {
                                tutar = 45;
                            }

                        }
                    }
                }
                else if (saat > 24)
                {
                    tutar = 45 + (int)(saat / 24) * 25;
                }

                Console.WriteLine($" .... Plakalı Minibüs {saat} saat park süresi için ödenecek tutar {tutar}TL dir");
            }

            if (aracTipi == "4")
            {
                if (saat < 2)
                {
                    tutar = 15;

                    if (saat > 2 && saat < 6)
                    {
                        tutar = 30;

                        if (saat > 6 && saat < 12)
                        {
                            tutar = 60;

                            if (saat > 12 && saat < 24)
                            {
                                tutar = 100;
                            }

                        }
                    }
                }
                else if (saat > 24)
                {
                    tutar = 100 + (int)(saat / 24) * 55;
                }
                Console.WriteLine($" .... Plakalı Kamyon {saat} saat park süresi için ödenecek tutar {tutar}TL dir");
            }

        }
    }
}
