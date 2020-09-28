using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessRules
{
    public class ActivateMemvership : Iorder
    {
        public string ProcessOrder()
        {
            IMembershipEmail membership = new MembershipEmail();
            membership.EMailDetails("activate the membership");
            return "activate the membership";
        }
    }
}
