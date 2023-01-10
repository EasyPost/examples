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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            PaymentMethod paymentMethod = await Client.Beta.Referral.AddPaymentMethod("cus_123", "ba_123");

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
        }
    }
}
