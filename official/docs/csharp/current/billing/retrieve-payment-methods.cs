using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            EasyPost.ClientManager.SetCurrent(apiKey);

            PaymentMethod paymentMethods = await Billing.RetrievePaymentMethods();

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethods, Formatting.Indented));
        }
    }
}
