using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabitler_ve_değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1)sabitler 
            //const:sabit değerleri tanımlamada kulanılır değerleri tanımladıkları anda verilmelidir örneğin 
            // tanımlanmış sabit bir değer değiştirilemez değiştirilirse derleme zamanı hata verir 

            /*  const int rakam = 45;*/
            /*
            const double pı = 3.14;//sabit bir değer olduğu için const kulandık 
            double alan, cevre, yarıçap;

            Console.Write("yarıçapı giriniz=");
            yarıçap = Convert.ToInt32(Console.ReadLine());

            cevre = 2 * pı * yarıçap;
            alan = pı * (Math.Pow(yarıçap, 2));// math sınıfına ait olan pow metodu üs almada kulanılır math.pow (değer ,üs) şeklinde kulanılır 
            Console.WriteLine("dairenin cevresi (cm)=" + cevre);
            Console.WriteLine("dairenin alanı (cm) = " + alan);
            Console.ReadLine();
            */
            /*
            const double urunfiyatı = 100;
            const double kdvlifiyat = urunfiyatı + (urunfiyatı * 0.18);
            byte adet = 0;
            Console.Write("ürün adedini giriniz: ");
            adet = Convert.ToByte(Console.ReadLine()); // byte de tam sayılar için kulanılır 
            Console.WriteLine("toplam fiyat =" + kdvlifiyat * adet);
            Console.ReadKey();
            */


        }
    }
}
