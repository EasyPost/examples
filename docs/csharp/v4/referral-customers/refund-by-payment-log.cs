using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            PaymentRefund refund = await Client.Beta.Referral.RefundByPaymentLog("paylog_...");

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
