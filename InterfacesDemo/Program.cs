using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        //SOLID, Interface Segregation araştırılabilir.
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach(var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach(var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
            
        }
    }

    interface IWorker
    {
        void Work();
    }
    
    interface IEat
    {
        void Eat(); 
    }

    interface ISalary
    {
        void GetSalary();
    }

    //Birden fazla interface kullanabiliyoruz.
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat(For Manager)");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get Salary(For Manager)");
        }

        public void Work()
        {
            Console.WriteLine("Work(For Manager)");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat(For Worker)");
        }

        public void GetSalary()
        {
            Console.WriteLine("Get Salary(For Worker)");
        }

        public void Work()
        {
            Console.WriteLine("Work(For Worker)");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work(For Robot)");
        }
    }
}
