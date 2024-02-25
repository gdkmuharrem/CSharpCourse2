using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager personManager = new IPersonManager();
            // Interface newlenemez !!!
            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());


            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları buraya gelecek.
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Çalışan ekleme kodları buraya gelecek.
            Console.WriteLine("Çalışan Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Çalışan Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
