using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    public abstract class OrderProcessingFactory
    {
        public abstract Iorder getOrderDetails(string orderType);
    }
}
