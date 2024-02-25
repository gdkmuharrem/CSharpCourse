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
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Muharrem";
            customer.LastName = "Gedik";

            Customer customer2 = new Customer
            {
                City = "İstanbul",
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Gedik"
            };
            Console.WriteLine(customer2.FirstName +" "+ customer2.LastName);



            Console.ReadLine();
        }
    }
}
