using CustomerEncapApp.Model;
using System;

namespace CustomerEncapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 1000;
            c1.Name = "shyam";
            Console.WriteLine("Let us see details of object");
            Console.WriteLine("order counts till now " + c1.OrderCount());
            Console.WriteLine("Customer Name : " + c1.Name );
            Console.WriteLine("Customer Id : " + c1.Id);
            Console.WriteLine("Let us make some orders .");
            c1.PlaceOrder();
            c1.PlaceOrder();
            Console.WriteLine("order counts after making order " + c1.OrderCount());
            Console.WriteLine("Customer Name : " + c1.Name);
            Console.WriteLine("Customer Id : " + c1.Id);
        
        }
    }
}
