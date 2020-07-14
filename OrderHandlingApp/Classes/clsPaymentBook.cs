using System;
using System.Collections.Generic;
using System.Text;

namespace OrderHandlingApp.Classes
{
    class clsPaymentBook : IBook, IGenerateCommissionAgent
    {
        public string CreateDuplicatePackingSlipForRoyalty()
        {
            //code to create duplicate packing slip for royalty department
            return "create duplicate packing slip for royalty department";
        }
        public string GenerateCommissionPayment()
        {
            //code to generate commission payment to the agent
            return "generate commission payment to the agent";
        }



    }


}
