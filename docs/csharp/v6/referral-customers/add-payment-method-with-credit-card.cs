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

            EasyPost.Models.API.PaymentMethod paymentMethod = await client.Beta.ReferralCustomer.AddPaymentMethod("cus_...", "card_...", PaymentMethod.Priority.Primary);

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
        }
    }
}
