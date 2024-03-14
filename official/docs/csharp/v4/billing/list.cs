using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            PaymentMethod paymentMethods = await client.Billing.RetrievePaymentMethods();

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethods, Formatting.Indented));
        }
    }
}
