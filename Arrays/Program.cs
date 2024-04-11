using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Tuğçe";
            //string student3 = "Kürşad";
            //hepsi ayrı ayrı değişken olduğu için bunların yönetimi zor olur. Arrayler ile aynı tipteki değerleri tek bir döngüde yönetmek için kullanırız.

            string[] students = new string[3];
            students[0] = "Ayşe";   //sıralama 0'dan başlıyor, unutma!
            students[1] = "Tuğçe";
            students[2] = "Kürşad";

            string[] students2 = new[] { "Ayşe", "Tuğçe", "Kürşad" };
            //Bu şekilde de değerler verilebilir. Başındaki new kaldırılıp da yazılabilir. Bir değişiklik olmaz.
            
            //Arrayler de hangi tip değer verilecekse o veri tipi seçilmeli. String yazıp sayı kullanamayız.

            foreach (var student in students)  //foreach döngüsü bir array'i gezmek için kullanılır.
            {
                Console.WriteLine(student);
            }

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("********");
            //Çok boyutlu diziler dersi:

            string[,] regions = new string[5, 3]   //5 satır, 3 kolonluk dizi yazıcaz demek.
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++) //Sıfırıncı dimensionun en üst değeri.
            { 
                for (int j = 0; j <= regions.GetUpperBound(1); j++)  //Bu da sütündaki değerleri için döngü.
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("********"); //Her bölge bittiğinde yıldız koyması için.
            } 


            Console.ReadLine();
        }
    }
}
