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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            PaymentMethod paymentMethod = await client.Beta.ReferralCustomer.AddPaymentMethod("cus_...", "ba_...", PaymentMethod.Priority.Primary);

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
        }
    }
}
