using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Engin"},
                new Student{FirstName = "Derin"}, //Buraya new Person da ekleyebiliriz. Çünkü interface de person tek başına bir anlam ifade etmiyor ancak inheritancelarda person da kullanılabilir.
                new Person{ FirstName = "Tuğçe" }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //class Person2
    //{
        //Bu nesneyi birden fazla implement yapamayız. Customer : Person,Person2 gibi yazamayız.
        //Interface IPerson oluştursaydık, inheritance ekledikten sonra interface de ekleyebilirdik.
        //class Customer : Person, IPerson gibi
    //}

    class Customer : Person //Interface olduğu gibi kullanabiliyoruz. Customer person özellikleri alır, ayrı özellikler de eklenebilir.
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
