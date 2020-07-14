using System;
using System.Collections.Generic;
using System.Text;

namespace OrderHandlingApp.Classes
{
    class clsPaymentMembership : IMembership, IEmailOwnerAndIntimateUpgrade
    {
         public string ActivateMembership()
        {
            //code to activate membership
            return "activate membership";
        }
        public string EmailOwner()
        {
            //code to email the owner and inform them about the upgrade
            return "email the owner and inform them about the upgrade";
        }

    }
}
