using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum8._4
{
//    8.4 HAVAYOLLARI REZERVASYON SİSTEMİ
//Küçük bir havayolu şirketi rezervasyon kayıtlarını tutmak için bir program yazmanızı istemiştir.Havayolu şirketinin sahip olduğu uçaklar küçük boyutlarda ve toplamda 20 koltuk kapasitelidir. 20 koltuktan 8 tanesi Business Class, 12 tanesi Economy Class koltuklardır.
//Rezervasyonlar sınıf, koltuk numarası ve kişi ismi alınarak yapılmaktadır.Program açıldığında kullanıcıya iki seçenek sunulmalıdır:
//1. Business Class bölümü için 1 tuşuna basın
//2. Economy Class bölümü için 2 tuşuna basın
//Kullanıcı bu iki seçenekten birisini seçmelidir. Eğer ki yanlış bir giriş yaptıysa program bunu dikkate almayacak ve seçenekler ekranda kalacaktır.
//Sınıf seçimi yapıldıktan sonra kullanıcıya boş koltuk numaraları listelenecektir.Örneğin Economy Class seçimi yapıldıktan sonra:
//Economy Class bölümünde kalan boş koltuklar:
// 9
// 12
// 13
// 19
// 20
//Kullanıcı boştaki koltuk numaralarından birisini ekrana yazar ve Enter tuşuna basar.Eğer kullanıcı boş olmayan bir koltuk seçtiyse, ilgili koltuk kimin adına rezerve edildiyse isimle birlikte uyarı verilmelidir:
//11 Numaralı koltuğu daha önce “Tsubasa Ozora” isimli yolcuya rezerve ettiniz!
//Lütfen boş koltuklardan birisini seçiniz
//Economy Class bölümünde kalan boş koltuklar:
// 9
// 12
// 13
// 19
// 20
//Kullanıcı uygun koltuklardan birisini seçtikten sonra yolcu adı ve soyadı istenecektir:
//Lütfen yolcunun Adı ve Soyadını yazın: Misaki Taro
//İsim yazılıp Enter tuşuna basıldıktan sonra seçilen koltuk kişiye rezerve edilecek ve ekrana sonuç yazdırılacaktır:
//Economy Class bölümündeki 13 Numaralı koltuğu Misaki Taro isimli yolcuya rezerve ettiniz.
//Devam etmek için bir tuşa basın.
//Kullanıcı bir tuşa bastığında program başa döner ve ilk ekrana gelen sınıf seçenekleri görüntülenir.
//Eğer ki sınıf seçildikten sonra o sınıfta boş koltuk kalmadıysa kullanıcıya şu uyarı döndürülmelidir:
//Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır.Economy Class bölümündeki boş koltukları görmek ister misiniz? E/H
//Kullanıcı E seçeneğini seçerse, sınıf seçimi işleminden sonraki akış aynen uygulanacaktır.Eğer kullanıcı H bölümünü seçerse ekrana şu uyarı döndürülecektir:
//Bir sonraki uçuş kayıtları 4 saat sonradır.
//Bir sonraki uçuş uyarısı ekrana getirildikten sonra program ilk duruma döner ve sınıf seçeneklerini ekrana getirir.
//Örnek, tek boyutlu string tipinde değerler alan bir dizi ile çözülmelidir. Koltuk numaraları ile index değerleri uygun şekilde eşleştirilerek program geliştirilmelidir.
    class Program
    {
        static void Main(string[] args)
        {
            Bilgilendirme();
            Rezervasyon(Secenekler());
            Console.ReadLine();
        }
        static void Bilgilendirme()
        {
            Console.WriteLine("***************HOŞGELDİNİZ***************");
            Console.WriteLine("Bu programda size uçak bileti rezervasyonu yaptırılacaktır");
            Console.WriteLine("***************İYİ GÜNLER DİLERİZ***************");
        }
        static string Secenekler()
        {
            string secenek = string.Empty;
            do
            {

                Console.WriteLine("Business Class bölümü için 1 tuşuna basın / Economy Class bölümü için 2 tuşuna basın ");
                secenek = Console.ReadLine();
                while (secenek != "1" && secenek != "2")
                {
                    Console.Clear();
                    Bilgilendirme();
                    Console.WriteLine("Business Class bölümü için 1 tuşuna basın / Economy Class bölümü için 2 tuşuna basın ");
                    secenek = Console.ReadLine();

                }
            } while (secenek != "1" && secenek != "2");

            return secenek;
        }
        static string DevamEtmeDurumu()
        {
            string devamEtmeDurumu = "yes";
            Console.WriteLine("bilet almaya devam mı? ");
            devamEtmeDurumu = Console.ReadLine();
            if (devamEtmeDurumu == "yes")
            {
                Secenekler();
            }
            else if (devamEtmeDurumu == "no")
            {
                Console.Clear();
                Console.WriteLine("Bizi Tercih ettiğiniz için teşekkür ederiz, iyi yolculuklar");
                Console.ReadLine();
            }
            return devamEtmeDurumu;
        }


        static void Rezervasyon(string secenek)
        {

            int[] businessBos = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] economyBos = { 9, 12, 13, 19, 20 };
            string cevap = string.Empty;
            do
            {
                do
                {
                    if (secenek == "2" || cevap == "e" || cevap == "E")
                    {
                        if (economyBos.Length != 0)
                        {
                            Console.WriteLine($"Boş koltuklardan birini seçiniz.");
                            foreach (int item in economyBos)
                            {
                                Console.WriteLine(item);
                            }
                            int secilenKoltukNo = Convert.ToInt32(Console.ReadLine());

                            switch (secilenKoltukNo)
                            {
                                case 9:
                                    Array.Clear(economyBos, 0, 0);
                                    Array.Sort(economyBos);
                                    Array.Resize(ref economyBos, economyBos.Length - 1);
                                    break;
                                case 12:
                                    Array.Clear(economyBos, 1, 0);
                                    Array.Sort(economyBos);
                                    Array.Resize(ref economyBos, economyBos.Length - 1);
                                    break;
                                case 13:
                                    Array.Clear(economyBos, 2, 0);
                                    Array.Sort(economyBos);
                                    Array.Resize(ref economyBos, economyBos.Length - 1);
                                    break;
                                case 19:
                                    Array.Clear(economyBos, 3, 0);
                                    Array.Sort(economyBos);
                                    Array.Resize(ref economyBos, economyBos.Length - 1);
                                    break;
                                case 20:
                                    Array.Clear(economyBos, 4, 0);
                                    Array.Sort(economyBos);
                                    Array.Resize(ref economyBos, economyBos.Length - 1);
                                    break;
                            }
                            Console.WriteLine("Lüften Adınızı Soyadınızı Giriniz");
                            string yolcuBilgisi = Console.ReadLine();
                            Console.WriteLine($"Economy Class bölümündeki {secilenKoltukNo} numaralı koltuk {yolcuBilgisi} yolcuya rezerve edilmiştir.");
                            DevamEtmeDurumu();
                        }
                        else if (economyBos.Length == 0 && businessBos.Length != 0)
                        {
                            Console.WriteLine("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır. Business Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                            cevap = Console.ReadLine();
                        }
                        else if (cevap == "H" || cevap == "h")
                        {
                            Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                        }

                    }
                } while (economyBos.Length != 0 && businessBos.Length == 0);

                do
                {
                    if (secenek == "1" || (cevap == "E" || cevap == "e"))
                    {
                        if (businessBos.Length != 0)
                        {
                            Console.WriteLine($"Boş koltuklardan birini seçiniz.");
                            foreach (int item in businessBos)
                            {
                                Console.WriteLine(item);
                            }
                            int secilenKoltukNo = Convert.ToInt32(Console.ReadLine());

                            switch (secilenKoltukNo)
                            {
                                case 1:
                                    Array.Clear(businessBos, 0, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 2:
                                    Array.Clear(businessBos, 1, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 3:
                                    Array.Clear(businessBos, 2, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 4:
                                    Array.Clear(businessBos, 3, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 5:
                                    Array.Clear(businessBos, 4, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 6:
                                    Array.Clear(businessBos, 5, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 7:
                                    Array.Clear(businessBos, 6, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                                case 8:
                                    Array.Clear(businessBos, 7, 0);
                                    Array.Sort(businessBos);
                                    Array.Resize(ref businessBos, businessBos.Length - 1);
                                    break;
                            }
                            Console.WriteLine("Lüften Adınızı Soyadınızı Giriniz");
                            string yolcuBilgisi = Console.ReadLine();
                            Console.WriteLine($"Business Class bölümündeki {secilenKoltukNo} numaralı koltuk {yolcuBilgisi} yolcuya rezerve edilmiştir.");
                            DevamEtmeDurumu();
                        }

                        else if (businessBos.Length == 0 && economyBos.Length != 0)
                        {
                            Console.WriteLine("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır. Economy Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                            cevap = Console.ReadLine();
                        }
                        else if (cevap == "H" || cevap == "h")
                        {
                            Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                        }

                    }
                } while (businessBos.Length != 0 && economyBos.Length == 0);
               
            } while (businessBos.Length != 0 && economyBos.Length != 0);

            Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");


        }
    }
}









