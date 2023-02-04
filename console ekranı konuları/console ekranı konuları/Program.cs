using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_ekranı_konuları
{
    class Program
    {
        static void Main(string[] args)
        {
            //konosol ekranında değer yazma ve okuma 
            //1) write ve writeline metotları
            // write metodu verilen değer aynı satıra yazdırır 
            // writline metodu ise verilen değeri satıra yazdırır ve sonra alt satıra gecer 

            /*Console.Write("şehmus \n "); //\n alt satıra geçmek için kulanılır 
            Console.WriteLine(" şehmus çakar ");
            Console.ReadKey();*/

            //2) Read ve Readline metotları 
            //readline metodu string değerleri okumak için geriye değer döndürülür 
            // read metodu ise int değerlieri okumak için geriye değer döndürülür ,galiba char karekterleri de 
            // bunlar kulanıcıda girdi almak için kulanılır yani 
            /*
            string ad;
            Console.Write("ADINIZI GİRİNİZ:");
            ad = Console.ReadLine();
            Console.WriteLine(ad);
            Console.ReadKey();// BU METOD HERHANGİ BİR TUŞA BASINCAYA KADAR conole ekranını acık tutar 
            */
            /*
            string numara1, numara2;
            Console.Write("1.numarayı girin:");
            numara1 = Console.ReadLine();
            Console.Write("2.numarayı girin:");
            numara2 = Console.ReadLine();
            Console.WriteLine(" GİRİLEN NUMARALAR {0} VE {1} ", numara1, numara2);
            Console.ReadKey();
            */
            /*
            Console.WriteLine("adınızı girin:");
            string ad = Console.ReadLine();
            Console.WriteLine("yaşınızı girin:");
            int yas = Convert.ToInt32(Console.ReadLine());// bu readline olduğu için bunu convert ile int dünüştürdük böyle oluyor 
            Console.WriteLine("Aınızı {0} Yasınız {1}.uygulamamıza hoş geldiniz {0}", ad, yas);// index numaraları nasıl yazdırırsan öyle olur 
            Console.ReadKey();
            */
            /*
            Console.WriteLine("Adınızı girin");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınızı girin");
            string soyad = Console.ReadLine();
            Console.WriteLine("yaşınızı girin");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adınız |{0,-10}| soyadınız |{1,-4}| yasınız|{2,10}|", ad, soyad, yas);// buda aralıkla yazılmasını sağlar 
            Console.ReadKey();
            */
            //3)backgroundcolor ve foregroundcolor metotlar 
            // backgroundcolor : konsol ekranında yazılan yazıların arka plan renklerini değiştirir 
            //foregroundcolor: yazı rengini değiştirmek için kulanılır 
            /*
             Console.BackgroundColor = ConsoleColor.Red;
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.Write("Adınızı girin:");
             Console.ReadKey();
            */
            //----------------
            /*
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Adınızı girin:");
            Console.ResetColor();// bu eski renklerine döndürmek için kulanılır ve kulanılan satırdan sonra etkili olur
            Console.WriteLine("soyadınızı girin:");
            Console.ReadKey();
            */
            //----------------------
            /*

            char karekter;
            Console.Write("bir tuşa basarak ardından enter'a basınız ");
            karekter = (char)Console.Read();// char ı buyle dönüstürerek okutabilirsin 
            Console.WriteLine("basılan tuş :" + karekter);
            Console.ReadKey();
            */
            //4)setcursorposıtıon metodu :imleci konsol ekranında belirtilen kordinata konumlandırmak için kulanıılr 
            //  SetCursorPosition(int yatay koordinat, int dikey koordinat);

            /*
            // SetWindowSize( int genişlik , int yükseklik)
            Console.SetWindowSize(30, 15);
            Console.SetWindowPosition(Console.WindowHeight / 2, Console.WindowHeight / 2); // ekranın genişlik ve yükseklik değerlerini elde ederek bu 
            // değerleri ikiye bölerek   Console.SetWindowPosition bu metot ile bunlar yapılır 
            Console.WriteLine(" c sharp");
            Console.ReadLine();
            */
            //5) konsol uygulamalarından cıkış 
            Console.WriteLine("cıkmak isteğinizden emin misiniz [E/H]");
            string cevap = Console.ReadLine();
            if (cevap == "E")
                Environment.Exit(0);
            else
                Console.WriteLine("devam");
            Console.ReadLine();// kod bloğundan cıktım burda 


        }
    }
}
