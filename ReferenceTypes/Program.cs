using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variablesTypes();
            //----------------------------------------------------
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Muharrem";
            person2 = person1;
            person1.FirstName = "Ahmet";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            Employee employee = new Employee();

            employee.FirstName = "Mahmut";
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678910";
            Person person3 = customer;
            customer.FirstName = "Ahmet";
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            //----------------------------------------------------
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);






            Console.ReadLine();
        }

        private static void variablesTypes()
        {
            /*
            int,decimal,float,enum,boolean ==> value types (değer tipleri) olduğu için değer tutarlar.
            */
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("Sayi 1 = " + sayi1); // sayi1 = 20
            /*
             array,class,interface,... ==> reference types (referans tipleri) olduğu için adres tutarlar.
             */
            int[] sayilar = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar[0]);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
