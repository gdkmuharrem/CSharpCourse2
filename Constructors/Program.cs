using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id = 1, FirstName = "Muharrem",LastName ="Gedik",City = "İstanbul" };
            Customer customer2 = new Customer(2,"Mehmet","Yildiz","Adana");
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
    class Customer
    {
        // Defaulth Constructor ==> Yazılsa da yazılmasa da arka planda otomatik olarak oluşturulur.
        public Customer()
        { 

        }
        // Özelleştirdiğimiz Constructor
        public Customer(int id,string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
