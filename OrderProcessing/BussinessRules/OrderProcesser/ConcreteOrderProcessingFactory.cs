using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    public class ConcreteOrderProcessingFactory : OrderProcessingFactory
    {
        public override Iorder getOrderDetails(string orderType)
        {
            switch (orderType)
            {
                case "physicalProduct":
                    {
                        return new PhysicalProduct();
                    }
                case "Book":
                    {
                        return new Book();
                    }
                case "membership":
                    {
                        return new ActivateMemvership();
                    }
                case "upgradeToMembership":
                    {
                        return new UpgrateMembership();
                    }
                case "Learning to Ski":
                    {
                        return new LearningToSki();
                    }
                default:
                    {
                        return new PhysicalProduct();
                    }
            }
        }
    }
}
