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

            EasyPost.Parameters.ReferralCustomer.RefundByAmount parameters = new()
            {
                Amount = 2000,
            };

            EasyPost.Models.API.PaymentRefund refund = await client.Beta.ReferralCustomer.RefundByAmount(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
