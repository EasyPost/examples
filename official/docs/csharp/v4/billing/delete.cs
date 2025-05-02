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

            bool success = await client.Billing.DeletePaymentMethod(PaymentMethod.Priority.Primary);

            Console.WriteLine(success.ToString());
        }
    }
}
