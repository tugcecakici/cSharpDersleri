using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //elimizde bir veri kümesi var ve bu kümede dolaşmak istiyoruz. Bu sebeple döngüleri kullanırız.
            for (int i = 0; i <= 10; i++) // 0'dan başlayarak 100'e kadar olan sayılar ekrana yazılıyor.
                
                //int i = 0 bu başlangıç değerini ifade ediyor.
                //i<=100 şartımız oluyor, i 100'den küçük eşit olana kadar döngüyü devam ettir demek.
                //i++ her dönüş bittiğinde diğer döngüde i sayısını 1 arttır demek.
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            for (int i = 1;i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }

            //10'a kadar olan tek sayılar
            Console.WriteLine("Tek sayılar bitti!");

            for (int i = 0;i <= 10 ; i=i+2)
            {
                Console.WriteLine(i);
            }
            //10'a kadar olan çift sayılar

            Console.WriteLine("Çift sayılar bitti!");


            //WHİLE DÖNGÜSÜ DERSİ:
            int number = 15;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--; //sayıyı bir bir azalt demek.
            }
            Console.WriteLine("Now number is {0}", number);  // 0 ile döngüyü tamamlayıp buraya geçiyor. O yüzden -1 yazdı.

            //DO-WHİLE DÖNGÜSÜ:
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;

            } while (number>=11);
            //önce do çalışır sonra şart çalışır. Şart sağlanmasa bile do 1 kez çalışır.
            //mesela yukarıda şart sayının 11'den büyük olması ama ona rağmen 1 kez çalışır ve ekrana 10 yazısı gelir.


            //FOREACH DÖNGÜSÜ DERSİ: dizi temelli dataların döngüsü için kullanılır.

            string[] students = new string[3] {"Kürşad", "Tuğçe", "Dilara" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
                //foreach döngüsü içinde eleman değiştirilemiyor. string student = "Ahmet"; yazamayız.
            }

            Console.ReadLine();
        }
    }
}
