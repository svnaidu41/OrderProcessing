using BussinessRules;
using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessingFactory orderProcessingFactory = new ConcreteOrderProcessingFactory();
            Iorder order = orderProcessingFactory.getOrderDetails("Learning to Ski");
            Console.WriteLine(order.ProcessOrder()); 
        }
    }
}
