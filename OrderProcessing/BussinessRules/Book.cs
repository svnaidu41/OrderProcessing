using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    class Book : Iorder
    {
        public string ProcessOrder()
        {
            IcommissionOrders commissionOrders = new CommissionOrders();
            commissionOrders.GenerateCommissionPayment();
            return "duplicate packing slip for the royalty department";
        }
    }
}
