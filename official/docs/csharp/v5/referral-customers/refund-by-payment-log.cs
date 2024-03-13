using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Parameters.ReferralCustomer.RefundByPaymentLog parameters = new()
            {
                PaymentLogId = "paylog_...",
            };

            PaymentRefund refund = await client.Beta.ReferralCustomer.RefundByPaymentLog(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
