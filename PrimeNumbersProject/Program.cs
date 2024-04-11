using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(17))
            {
                Console.WriteLine("This is a prime number!");
            }
            else
            {
                Console.WriteLine("This is not a prime number!");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)  //2'den başladık, kendinden 1 eksik tüm sayıları kontrol ederek bölümünden kalan kontrol edilir.
                //örneğin 3 = 2ye bölünüyor mu bak.  
                //5= 4e bölünüyor mu bak, 3e bölünüyor mu bak vs.
            {
                if (number%i==0) //eğer bölünen bir sayı varsa sonucu false yap. asal değil.
                {
                    result = false;
                    i = number; //döngünün sürekli devam etmemesi için.
                }
            }
            return result;
        }

    }
}
