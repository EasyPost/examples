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

            ReferralCustomerCollection referralCustomerCollection = await client.Partner.All(
                new Dictionary<string, object>
                {
                    { "page_size", 5 }
                }
            );

            List<ReferralCustomer> referralCustomers = referralCustomerCollection.ReferralCustomers;

            Console.WriteLine(JsonConvert.SerializeObject(referralCustomers, Formatting.Indented));
        }
    }
}
