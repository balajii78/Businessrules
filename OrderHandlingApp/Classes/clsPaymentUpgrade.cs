using System;
using System.Collections.Generic;
using System.Text;

namespace OrderHandlingApp.Classes
{
    class clsPaymentUpgrade : IUpgrade, IEmailOwnerAndIntimateUpgrade
    {
         public string ApplyUpgrade()
        {
            //code to apply upgrade
            return "apply upgrade";
        }
        public string EmailOwner()
        {
            //code to email the owner and inform them about the upgrade
            return "email the owner and inform them about the upgrade";
        }

    }
}
