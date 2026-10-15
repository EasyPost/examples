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

            EasyPost.Models.API.PaymentMethod paymentMethods = await client.Billing.RetrievePaymentMethods();

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethods, Formatting.Indented));
        }
    }
}
