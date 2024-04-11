using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer();
            manager.Add(new Customer { Id = 1, Name = "Tuğçe", LastName = "Çakıcı", Address = "Manisa" });

            Student student = new Student();
            {
                student.Id = 2;
                student.Name = "Kürşad";
                student.LastName = "Uslu";
                student.Department = "Fizik";
                manager.Add(student);
                student.Add(student); //Bu departmanı ekliyor.
            }
            manager.Add(new Customer { Id = 3, Name = "Gökçe", LastName = "Çakıcı", Address = "Manisa" });

            Customer customer2 = new Customer
            {
                Id = 4,
                Name = "Irmak",
                LastName = "Çakıcı",
                Address = "Manisa",
            };
            manager.Add(customer2);

            Student student2 = new Student
            {
                Department = "Lise",
                Name = "Ayşe",
                LastName = "Çakıcı",
                Id = 5,

            };
            manager.Add(student2);
            

            Console.ReadLine();
        }
    }

    interface IPerson //isimlendirmede hep ilk başta I kullanılır.
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        //bunlar somut nesneler.Interface ise soyut bir nesnedir.
        //Iperson'da tanımlanmış her şeyi customer ve student classında da görebiliriz demek.
        //Implement interface diyince bu şekilde otomatik yapıyor.
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        //müşteri ve öğrenci ortak özellik IPerson ile tanımlandı.
        //Ayrı ayrı özel olarak da property belirlenebilir.


        //Bu şekilde de implement yapılabilir.

        public void Add(Student student)
        {
            Console.WriteLine(Department);
        }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("ID: " + person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.LastName);

        }


    }
}
