using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            //Aşağıda Add isminde metot oluşturduk ve buraya direkt metot olarak ekleyebiliyoruz.
            //Metot kullanılma sebebi kendimizi tekrarlamamızı engellemek için. 

            Add2(2, 3);
            //Toplama metotu kullanılacak, bunun için parantez içine 2 tane sayı yazıyoruz. Bu değerler toplanıyor.
            //Bu şekilde yazdığımızda çalıştırdığımızda ekranda sonuç yazmaz.

            var result = Add2(15);
            //var yerine int de yazabiliriz, bir şey değişmez.
            Console.WriteLine(result);
            //Bu şekilde yazıldığında ekrana sonuç çıkar.

            int number1 = 20;
            int number2 = 30;
            var result2 = Add3(ref number1, number2);
            //ref değeri eklemiş olduk.
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            int number3;
            int number4 = 9;
            var result3 = Add4(out number3, number4);
            //out da ref keyword gibi çalışır. Aynı işlevi görürler.

            Console.WriteLine(result3);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(3,5,9));
            //İki aynı isimli methodu da kullanmış olduk.

            Console.WriteLine(Add5(1,5,6,4,5,8,12,15));
            //params olduğu için içerisine istediğimiz kadar sayı yazabiliriz.

            Console.ReadLine();
        }

        //aşağıda metot oluşturmuş olduk.
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //iki sayı toplaması için metot oluşturuyoruz.
        //void "git şu işlemi yap, bir yere bir şeyi yaz" anlamına gelir.
        //void yerine ne tipte bir veri döndürmek istersek o yazılır. Aşağıda toplama işlemi yapacağımız için
        //void yerine int yazıyoruz.
        static int Add2(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;

            //default parametrelerle çalışmak: int number2=30 yazarsak number2 için değer yazılmasa bile otomatik bu değer kullanılıyor.
            //eğer değer yazılırsa yazılan değer kullanılır.
            //default değer ilk değere yazılamaz!!Örneğin 3 değer varsa son 2 değere yazılabilir.
        }


        //ref keyword ile çalışma dersi:
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            //yukarıda number1=20 değeri vermiştik ancak metot içinde 30 dediğimiz için 30 değerini alır.
            //içeriye böyle bir referans değeri eklersek ref int şeklinde yazmamız gerekir.
            return number1 + number2;
        }

        //out keyword ile çalışma dersi:
        static int Add4(out int number3, int number4)
        {
            number3 = 50;
            return number3 + number4;

            //out ve ref farkı: !!ref keywordunde number1 değeri kesinlikle belirlenmiş olması gerekiyor.
            //out kullanırsak da metot içerisinde değer kesinlikle belirlenmiş olması gerekiyor.
        }

        //method overloading dersi:
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //Multiply methotunu aynı isimle tekrar kullanabiliyoruz. İç değerleri farklı olduğu sürece
        //Tekrar Multiply2 yazmamıza gerek yok. Buna "method overloading" deniyor.

        //params keyword ile çalışma dersi:

        //params ile kaç tane sayı istersek yollayabiliyoruz. Tekrar tekrar method overloading yapmamıza gerek yok.
        static int Add5(params int[] numbers)
        {
            //params keywordundan sonra, int number2 gibi bir değer yazamam ama önüne yazabilirim.
            //return number1 + number2; şeklinde yazamıyoruz hata verir.
            return numbers.Sum();
            //fonksiyon olarak bütün sayıları toplar.
        }
    }
}
