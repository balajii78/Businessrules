using System;
using OrderHandlingApp.Classes;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace OrderHandlingApp
{
    class Program
    {
       
       static void Main(string[] args)
        {
           
            OrderHandling();
           
         }
       
        // Method for Order handling 
      public static void OrderHandling()
      {
            try
            {
                Console.WriteLine("Payments");
                Console.WriteLine("---------------------");
                Console.WriteLine("b->book");
                Console.WriteLine("m->membership");
                Console.WriteLine("p->product");
                Console.WriteLine("u->upgrade");
                Console.WriteLine("v->video");
                Console.WriteLine("---------------------");
            p: Console.WriteLine("Please enter the first letter of the payment:");
                string PaymentType = Console.ReadLine();
                Console.ReadLine();
                // if(arrpaymentype.co)
                List<string> lstPaymentType = new List<string> { "b", "m", "p", "u", "v" };
                if (!lstPaymentType.Contains(PaymentType.ToLower()))
                {
                    Console.WriteLine("Invalid Payment");
                    goto p;

                }


                switch (PaymentType.ToLower())
                {
                    case "b":
                        {
                            clsPaymentBook paymentBook = new clsPaymentBook();
                            Console.WriteLine(paymentBook.CreateDuplicatePackingSlipForRoyalty());
                            Console.WriteLine(paymentBook.GenerateCommissionPayment());
                            Console.ReadLine();
                            

                        }
                        break;

                    case "m":
                        {
                            clsPaymentMembership paymentMembership = new clsPaymentMembership();
                            Console.WriteLine(paymentMembership.ActivateMembership());
                            Console.WriteLine(paymentMembership.EmailOwner());
                            Console.ReadLine();

                        }
                        break;

                    case "p":
                        {
                            clsPaymentPhysicalproduct physicalproduct = new clsPaymentPhysicalproduct();
                            Console.WriteLine(physicalproduct.GeneratePackingSlipforShipping());
                            Console.WriteLine(physicalproduct.GenerateCommissionPayment());
                            Console.ReadLine();

                        }
                        break;

                    case "u":
                        {
                            clsPaymentUpgrade paymentUpgrade = new clsPaymentUpgrade();
                            Console.WriteLine(paymentUpgrade.ApplyUpgrade());
                            Console.WriteLine(paymentUpgrade.EmailOwner());
                            Console.ReadLine();

                        }
                        break;

                    case "v":
                        {
                            clsPaymentVideo paymentVideo = new clsPaymentVideo();
                            Console.WriteLine(paymentVideo.AddFreeFirstAidVideo());
                            Console.ReadLine();

                        }
                        break;
                    default:
                        break;


                }

                goto p;
            }

            catch (Exception ex)
            {

                Console.WriteLine("Unhandled exception " + ex.Message + " " + ex.StackTrace);

            }
        }

    }



}
