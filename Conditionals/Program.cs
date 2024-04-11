using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 30;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20.");
            }

            //if şart bloğunda eğer sayı 10 ise şunu yazdır. Eğer 20 ise şunu yazdır.
            //else - yani hiç biri değilse şunu yazdır.
            //tek eşittir değer atama anlamına geldiği için if komutunda çift eşittir kullanılır.

            int number2 = 50;
            Console.WriteLine(number2 == 50 ? "Number is 50" : "Number is not 50");

            //Sorgulama bu şekilde de yazılabilir. Singlee Line If deniyor buna.

            string name = "Kürşad";
            if (name == "Tuğçe")
            {
                Console.WriteLine("She's name is Tuğçe");
            }
            else
            {
                Console.WriteLine("She's name is not Tuğçe. Name is {0}", name);
            }

            int number3 = 9;
            switch (number3)
            {
                case 9:
                    Console.WriteLine("Number is 9.");
                    break;

                case 10:
                    Console.WriteLine("Number is 10.");
                    break;

                default:
                    Console.WriteLine("Number is not 9 or 10.");
                    break;

             // Switch şart bloğu da if gibi kullanılıyor. Durum case olarak belirtiliyor. Eğer buysa bunu yaz deniyor.
             //Break komutu ile sonlandırılıyor. Break olmazsa hata verir. Bu şartlar sağlanmadığında yapılacak şey ise "default" ile yazılıyor.

            }

            if (number3 >= 0 && number3<=100)
            {
                Console.WriteLine("Number is between 0 and 100.");
            }
            else if (number>100 && number <= 200)
            {
                Console.WriteLine("Number is between 100 and 200.");
            }
            else 
            {
                Console.WriteLine("Number is less then 0 or greater than 200.");
            }

            //&& bu işaret ve anlamına gelir. || bu işaret veya anlamına gelir.

            //"İç içe if blokları ile çalışmak".

            int number4 = 97;

            if (number4 < 300)
            {
                if (number4 >= 90 && number4 < 100)
                {
                    if (number4 >= 95 && number4 < 100)
                    {
                        Console.WriteLine("Number is between 95 and 100.");
                    }
                    else 
                    { 
                        Console.WriteLine("Number is bigger than 90 or less than 95.");
                    }
                }

                else
                {
                    Console.WriteLine("Number is not between 90 and 100.");
                }

            }
            else 
            { 
                Console.WriteLine("Number is not less than 300");
            }


            Console.ReadLine();
        }
    }
}
