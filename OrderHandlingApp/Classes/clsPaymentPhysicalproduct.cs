using System;
using System.Collections.Generic;
using System.Text;

namespace OrderHandlingApp.Classes
{
    class clsPaymentPhysicalproduct : IPhysicalproduct, IGenerateCommissionAgent
    {
        public string GeneratePackingSlipforShipping()
        {
            // code to generate packing slip for shipping
            return "generate packing slip for shipping";
        }
        public string GenerateCommissionPayment()
        {
            //code to generate commission payment to the agent
            return "generate commission payment to the agent";
        }
    }


}
