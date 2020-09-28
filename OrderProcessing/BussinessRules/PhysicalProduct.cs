using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    public class PhysicalProduct : Iorder
    {

        public string ProcessOrder()
        {
            IcommissionOrders commissionOrders = new CommissionOrders();
            commissionOrders.GenerateCommissionPayment();
            PackingSlip packingSlip = new PackingSlip();
            return packingSlip.GeneratePackingSlip();
        }
    }
}
