using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    public class UpgrateMembership:Iorder
    {
        public string ProcessOrder()
        {
            IMembershipEmail membership = new MembershipEmail();
            membership.EMailDetails("Upgrated the membership");
            return "Upgrated the membership";
        }
    }
}
