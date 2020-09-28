using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
   public class LearningToSki : Iorder
    {
        public string ProcessOrder()
        {
            PackingSlip packingSlip = new PackingSlip();
            return packingSlip.GeneratePackingSlip(true);
        }
    }
}
