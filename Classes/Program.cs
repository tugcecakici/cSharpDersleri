using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clasları yapmak istediğimiz işlemleri gruplara ayırmak için kullanırız. 
            CustomerManager customerManager = new CustomerManager(); //kullanmak için böyle yazmamız gerekiyor.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.City = "Denizli";
            customer.FirstName = "Kürşad";
            customer.LastName = "Uslu";

            Customer customer2 = new Customer
            {
                ID = 2,
                City = "Denizli",
                FirstName = "Tuğçe",
                LastName = "Çakıcı"
            };

            Console.WriteLine(customer2.FirstName + " " + customer2.LastName + " " + customer.City);
            Console.WriteLine(customer.FirstName);


            Console.ReadLine();
        }
    }
    //add/new item/class ekleyerek ayrı bir dosya gibi class ekleyebiliriz.
    //ya da aşağıdaki gibi de ekleyebiliriz.


    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }

    class Customer
    {
        //field tanımlamak
        //public string FirstName;


        //property tanımlamak
        public int ID { get; set; }
        string _firstName;
        public string FirstName
        {
            get
            {return "Mr. " + _firstName;} //İsmin öncesine Mr. ekle demek.
            set
            {_firstName = value;}
        }
        public string LastName { get; set; }
        public string City { get; set; }

        //get ve set dediğimiz bloklar ne işe yarıyor?  
        // get ve set ederken farklı bir şey de eklemek istersek yukarıdaki şekilde kullanırız. Buna da encapsulation denir.
    }

}
