using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            // int tam sayı değerler için, sınırı yaklaşık +-2 milyar. 32 bit yer kaplar.

            Console.WriteLine("Number 1 is {0} and Number 2 is {1}", number1, number2);
            // virgülden sonra yazılan değer cümle içine getirilir. Saymaya 0'dan başlandığı için ilk değer sıfır olarak yazılır.
            //Buna "index" denir.

            long number3 = 9223372036854775807;
            // long yukarıda yazılan değer max sınırıdır. Min sınırı da bu sayının eksili hali. 64 bitlik yer kaplar.
            Console.WriteLine(number3);

            short number4 = 42;
            //short int'ten daha az veri kapsar. 16 bit yer kaplar.
            Console.WriteLine(number4);

            byte number5 = 255;
            // byte 0 ve 255 arasındaki sayıları kapsar. 8 bitlik yer kaplar.
            Console.WriteLine(number5);

            //byte,short,int ve long tam sayı değişkenleri için kullanılır.

            bool condition = false;
            //bool mantıksal bir veri tipidir. Tuttuğu değer true ya da false olur. Şart bloklarında genelde kullanılır.

            char a = 'a';   
            //char karakterler için kullanılan değişken. a, b, c gibi.
            Console.WriteLine("Character is {0}" , (int)a);
            // Bunu bu şekilde int formuna değiştirdiğimizde karşımıza sayı çıkar. Çünkü her karakterin bir sayı karşılığı vardır.
            //Buna "ascii" deniliyormuş.

            double number6 = 3.2;
            //double ondalıklı sayılar için kullanılır. Bellekte 64 bitlik yer kaplıyor.
            Console.WriteLine(number6);

            decimal number7 = 0.256468m;
            //decimal daha uzun ondalıklı sayılar için.
            //double virgülden sonra 15-16 karakter, decimal ise 28-29 tane değer tutabiliyor.
            //decimal'de verilen değerinin sonuna m harfi konulması gerekiyor.
            Console.WriteLine(number7);

            //enum veri grubundan değer yazdırmak:
            Console.WriteLine("Today is {0}" , Days.Monday);
            Console.WriteLine((int)Days.Friday);
            //int dönüşümü yaptığımızda Fridayın sayısal karşılığı 4 olarak çıkıyor.
            //Çünkü enum sabitlerini saymaya başladığımızda Friday 4. değere karşılık geliyor. Saymaya sıfırdan başlanıyor.
            //Eğer aşağıdaki gibi monday=1 yazarsak 1'den saymaya başlar. Hepsine ayrı ayrı değer de verebiliriz.
            //Monday=10, Tuesday=20, Wednesday=30 vs gibi.

            var number8 = 10;
            number8 = 'A';
            Console.WriteLine("Number 8 is" , number8);

            //var number8 diyip int atadık. Sonrasında number8 = a dersek A karakterinin sayısal değerini verir.

            Console.ReadLine();

            //Console.Readline(); komutu uygulamayı çalıştırdığımızda direkt kapanmaması için yazılır.
            //Bu sayede bir tuşa basarak kapatırız.
        }
    }

    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    //class'ın dışına yazdık. Veri kümelerini tek tek string ile yazmak yerine "enum" olarak yazdık.
}
