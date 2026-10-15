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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.ReferralCustomer.RefundByPaymentLog parameters = new()
            {
                PaymentLogId = "paylog_...",
            };

            EasyPost.Models.API.PaymentRefund refund = await client.Beta.ReferralCustomer.RefundByPaymentLog(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
