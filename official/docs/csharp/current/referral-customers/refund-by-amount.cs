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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            PaymentRefund refund = await Client.Beta.Referral.RefundByAmount(2000);

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
