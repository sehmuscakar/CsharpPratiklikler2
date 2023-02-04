using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol_ekranı
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Console.Write("Volkan ");// write yazdırır alt satıra geçirmez
             Console.Write("aktaş");


             Console.WriteLine("volkan "); // buda yazdırır ama imleçi altıra getirir
             Console.WriteLine("aktaş");
            */

            //   Console.Write("kodlab" + "\t" + "yayınevi");// c# dili içerisinde \ karekterinin ardından kulanılan eylemler escape(kaçış)krekteri ismi verili ,kitapta var diğerleri


            /* Console.Write("ilk satır" + Environment.NewLine);// bu metod da alt satıra geçme yerine kulanılabilir
             Console.Write("ikinci satır");
             */
            // Console.WriteLine("{1},{0},{2}", 10, 20, 30);//böyle index numaralarını yazarak hangi sıraya göre yazılsın yazabilirsin ilk 0 inci index yazılır yani 20 


            //READ VE READLİNE METODLARI
            //değer okumak için kulanılırlar kulaıcıdan girilen değer 
            //readline :string ler için 
            // read :int değerler için 

            /*  //klavyeden girilen ismi konsol ekranına yazdıran uygulama 
              string ad;
              Console.Write("Adınızı Giriniz:");
              ad = Console.ReadLine();//string olarak kulanıcıdan alma 
              Console.Clear();//consol ekranını temizler üstü ama 
              Console.WriteLine(ad);

              Console.ReadKey();
            */

            /*
            //girilen doğum yılına göre yaşı hesaplayıp ekrana yazdıracak bir uygulama 
            Console.WriteLine("Doğum Yılınızı Girin:");          
            int yil = Console.Read();// burda da int olarak kulanıcıdan alma 
           // int yil = Convert.ToInt32(Console.ReadLine());//buda dönüştürme yapılmış hali  readline ile string yani 
            Console.WriteLine("Yaşınız" + DateTime.Now.Year + "-" + yil + "=" + (DateTime.Now.Year - yil));
            Console.ReadKey();
            */

            /*
            // klavyeden ayrı ayrı girilen iki adet numarayaı,belirten sırada ekrana yazdıraaan bir uygulama
            string numara1, numara2;// string olduğu için readline aklına gelsin
            Console.Write("1.numarayı giriniz:");
            numara1 = Console.ReadLine();
            Console.Write("2.numarayı giriniz:");
            numara2 = Console.ReadLine();
            Console.Clear();//üstü temizler
            Console.WriteLine("Girilen numaralar {0} ve {1}", numara1, numara2);
            Console.ReadKey();
            */

            /*
            //index numarası ilk sırada olan ad değerini,{0}şeklinde belirten uygulama 
            Console.WriteLine("Adınızı Giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("yaşınızı  Giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız {0} yaşınız {1}.uygulamamıza hoş geldiniz {0}", ad, yas);
            Console.ReadKey();
            */
            /*
            // yer tutucu kulanılarak koncol ekranına yazdırılan yazıyı sutunlar halinde hizalama 
            Console.WriteLine("Adınızı Giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("yaşınızı giriniz:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Adınız  |{0,-10}| soyadınız |{1,-4}| yaşınız |{2,10}| ", ad, soyad, yas);// örnek ad 10 karekter sola kayar ,yaş 10 karekterlik sağa kayar 
            Console.ReadKey();
            */
            //backgroundcolor metodu:konsol ekranında yazılan yazıların arkaplan renklerini değiştirir
            //foregroundcolor metodu:yazı rengini değiştirmek için kulanılır 

            /* Console.BackgroundColor = ConsoleColor.Gray;
             Console.ForegroundColor = ConsoleColor.DarkGray;
             Console.Write("Adınızı Girin:");
             Console.ReadKey();
            */

            //resetcolor metodu:yzı ve zemin renklerini,konsol ekranının varsayılan renklerine dündürebiliriz
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Adınızı Girin:");
            Console.ResetColor();
            Console.WriteLine("Soyadınızı Girin:");
            Console.ReadKey();






        }
    }
}
