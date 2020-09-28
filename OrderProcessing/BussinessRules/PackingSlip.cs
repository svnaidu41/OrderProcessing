using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    class PackingSlip : IPackingSlip
    {
        public string GeneratePackingSlip(bool isLearningToSki = false )
        {
            if (isLearningToSki)
            {
                FirstAidVideo firstAidVideo = new FirstAidVideo();
                return "free “First Aid” video to the packing slip (the result of a court decision in 1997)";
            }
            else
            {
                return "packing slip for shipping";
            }
        }
    }
}
