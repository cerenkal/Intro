using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bolum7
{
    //    7 DİZİLER
    //7.1 DİZİ ELEMANLARINI EKRANA YAZDIRMA
    //7.1.1 Dizi elemanlarını alt alta yazdırma
    //İlk aşamada dizi içerisindeki elemanlar bir döngü içerisinde alt alta yazdırılır.WriteLine metodu veya Write metonu içerisinde “\n” çıkış karakteri ile uygulama yaptırılabilir.
    //7.1.2 Dizi elemanlarını alt alta tersten yazdırma
    //İkinci aşamada dizi elemanlarının yerleri değiştirilmeden, dizi tersten ekrana yazdırılır. Bu örnekte öğrenciler, azalan döngü kurarak algoritmayı yazmalıdır.
    //7.1.3 Dizi elemanlarını yan yana yazma
    //Üçüncü aşamada dizi içerisindeki elemanlar 45 – 928 – 78 – 4 – 1007 – 83 şeklinde yan yana yazdırılır. Elemanlar arasında mutlaka bir ayraç karakter olmalıdır.İlk elemandan önce veya son elemandan sonra ekranda – (veya diğer bir ayraç) karakterinin olmaması gerektiği söylenir.Aynı örnek, dizi elemanlarını ters sırada soldan sağa yazdırarak da yapılabilir.
    //7.1.4 Dizi elemanlarını iki kolonda yazdırma
    //Dördüncü uygulamada dizi elemanları her satırda iki eleman, arada bir sekme boşluk olacak şekilde ekrana yazdırılır. Çıktı elde edildiğinde ekranda sanal iki kolonlu bir yapı görünmektedir:
    //**1**         **2**
    //dizi[0]      dizi[4]
    //dizi[1]      dizi[5]
    //dizi[2]      dizi[6]
    //dizi[3]      dizi[7]

    //Bu örnekte öğrenciler, tek elemanlı bir diziyi ekrana yazdırırken zorlanabilmektedir.Çift sayıda eleman sayısına sahip diziyi yapanlardan özellikle tek sayıda eleman sayısında dizilerin bu örnekte kullanılması istenmelidir
    //7.1.5 Dizi elemanlarını üç kolonda ters sırada yazdırma
    //Dördüncü olarak dizi elemanlarını 3 kolonlu sanal bir tabloya yazdırır.Ancak kolonların Right to Left formatta, sağdan sola dizilmiş şekilde olması gerektiği söylenir.Örnek çıktı aşağıdaki gibidir:
    //
    //
    //**1**    **2**   **3**
    //dizi[2] dizi[5] dizi[8]
    //dizi[1] dizi[4] dizi[7]
    //dizi[0] dizi[3] dizi[6]
    //                dizi[9]
    
    //7.2 DİZİNİN DEĞERLERİNİ TERS ÇEVİRME
    //7.2.1 İkinci bir dizi yardımıyla dizi elemanlarını ters sıralamak
    //Öncelikle birinci dizinin boyutunda yeni bir dizi oluşturarak, tek bir döngü içerisinde birinci dizideki her bir elemanı ikinci dizideki elemanlara ters sırada atamak ile yeni dizi elde edilir.
    //7.2.2 Aynı dizi üzerinde elemanları ters sıralamak
    //Aynı dizi üzerinde, dizi eleman sayısının yarısı kadar yürütülecek bir döngü içerisinde, klasik yer değiştirme algoritması kullanılarak dizi elemanları ters çevrilebilir.
    class Program
    {
        static void Main(string[] args)
        {
            #region 7.1.1

            //int[] diziler = {1, 2 , 3 , 4 , 5 };
            //foreach (int item in diziler)
            //{
            //    Console.Write(item+"\n");
            //}

            //Console.ReadLine();

            #endregion

            #region 7.1.2

            //int[] diziler = { 1, 2, 3, 4, 5 };

            //int temp = diziler[0];

            //for (int i = diziler.Length-1; i > 0; i--)
            //{
            //    Console.WriteLine(diziler[i]);
            //}
            //Console.WriteLine(temp);

            //Console.ReadLine();

            #endregion

            #region 7.1.3

            //int[] diziler = { 45, 928, 78, 4, 1007, 83 };
            //foreach (int item in diziler)
            //{
            //    Console.Write(item + "-");
            //}

            //int temp = diziler[0];

            //for (int i = diziler.Length - 1; i > 0; i--)
            //{
            //    Console.Write(diziler[i]+"-");
            //}
            //Console.Write(temp);

            //Console.ReadLine();

            #endregion

            #region 7.1.4

            //string[,] diziler = new string[5, 2];

            //diziler[0, 0] = "**1**";
            //diziler[0, 1] = "**2**";

            //diziler[1, 0] = "dizi[0]";
            //diziler[1, 1] = "dizi[1]";

            //diziler[2, 0] = "dizi[2]";
            //diziler[2, 1] = "dizi[3]";

            //diziler[3, 0] = "dizi[4]";
            //diziler[3, 1] = "dizi[5]";

            //diziler[4, 0] = "dizi[6]";
            //diziler[4, 1] = "dizi[7]";

            //for (int i = 0; i <= diziler.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= diziler.GetUpperBound(1); j++)
            //    {
            //        Console.Write(diziler[i, j] + "\t");
            //    }
            //    Console.WriteLine("  ");
            //}

            //***************************************************
            //*****************İKİNCİ YÖNTEM*********************
            //***************************************************

            //int[] dizi = { 0, 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("****1****  ****2****");

            //for (int i=0; i<dizi.Length ; i++)
            //{
            //    if (dizi[i] % 2 == 0)
            //    {
            //        if (dizi[i + 1] % 2 == 1)
            //        {
            //            Console.WriteLine($"    {dizi[i]}          {dizi[i + 1]}");
            //        }
            //    }
            //}
            //Console.ReadLine();

            #endregion

            #region 7.1.5

            //string[,] diziler = new string[5, 3];

            //diziler[0, 0] = "**3**";
            //diziler[0, 1] = "**2**";
            //diziler[0, 2] = "**1**";

            //diziler[1, 0] = "dizi[2]";
            //diziler[1, 1] = "dizi[1]";
            //diziler[1, 2] = "dizi[0]";

            //diziler[2, 0] = "dizi[5]";
            //diziler[2, 1] = "dizi[4]";
            //diziler[2, 2] = "dizi[3]";

            //diziler[3, 0] = "dizi[8]";
            //diziler[3, 1] = "dizi[7]";
            //diziler[3, 2] = "dizi[6]";

            //diziler[4, 2] = "dizi[9]";


            //for (int i = 0 ; i <= diziler.GetUpperBound(0); i++)
            //{
            //    for (int j = 0 ; j <= diziler.GetUpperBound(1); j++)
            //    {
            //        Console.Write(diziler[i, j]+"\t");
            //    }
            //    Console.WriteLine("  ");
            //    //Console.WriteLine($" |{ "Left",-7}|{ "Right",7}| "); right to left formatını bulamadım microsoft sitesinde buna benzer bir yapı vardı ama çalışmıyor
            //}

            //Console.ReadLine();

            #endregion

            #region 7.2.1

            //int[] dizi1 = new int[6] {1,5,9,70,64,3};
            //int[] dizi2 = new int[6];

            //for (int i = 0; i <dizi1.Length; i++)
            //{
            //    dizi2[(dizi1.Length-1)-i] = dizi1[i];

            //    Console.Write(dizi1[i]+",");
            //}
            //Console.WriteLine("\n---------------------------");
            //foreach (int item in dizi2)
            //{
            //    Console.Write(item+",");
            //}
            //Console.ReadLine();

            #endregion

            //#region 7.2.2

            //int[] diziler = new int[6] { 1, 5, 9, 70, 64, 3 };
            //int temp1 = diziler[0];
            //int temp2 = diziler[1];
            //int temp3 = diziler[2];
            //for (int i = (diziler.Length) - 1; i >= (diziler.Length) / 2; i--)
            //{
            //    Console.Write(diziler[i] + "-");
            //}
            //Console.Write(temp3 + "-");
            //Console.Write(temp2 + "-");
            //Console.Write(temp1);

            //Console.ReadLine();

            //#endregion
        }
    }
}
