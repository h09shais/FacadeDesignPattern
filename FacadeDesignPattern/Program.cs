using System;
using BLL;
using Entities;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderDetails = new []{
                new Order(1,
                    "Street No 1",
                    "Area",
                    "3423",
                    78789,
                    "5345345345"
                    ),
                new Order(2,
                    "Street No 1",
                    "Area",
                    "3423",
                    78789,
                    "5345345345"
                )
            };

            var order = new CustomerOrder();
            order.Finalize(orderDetails);

            Console.ReadLine();
        }
    }
}
