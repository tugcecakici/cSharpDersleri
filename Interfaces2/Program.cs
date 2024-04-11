using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
            customerManager.Delete(new SqlServerCustomerDal());
            customerManager.Delete(new  OracleCustomerDal());

            //Gerçek hayat kullanımı 2 Dersi:

            //Bir verimiz var ve bu veriyi hem SQL tabanına hem de Oracle veri tabanına yazmak istiyoruz;
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),  //2 elemanlı bir dizi olacak dedik. İlk eleman SQL, ikinci eleman Oracle.
            }; // Dizi oluşturarak yeni bir veritabanı eklediğimizde bu diziye ekleyerek direkt kullanabiliriz.

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
       }

        //Polymorphism çok biçimlilik anlamına gelmektedir.
        //Bir nesneyi farklı amaçlarla implemente edip, o implementlerin hepsine ulaşmak içindir.
    }
}
