using System;

namespace Classes
{
    class Program
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
            customer.city = "Eses";
            customer.FirstName = "Emre";
            customer.Id = 1;
            customer.LastName = "Gndgd";


            Customer customer1 = new Customer
            {
                Id = 2, city = "Muğla" , FirstName = "Yaren",LastName = "abc123"
            };

            Console.WriteLine(customer1.FirstName);
        }
    }
    
    
}
