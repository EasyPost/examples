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

            ReferralCustomer referralUser = await client.Partner.CreateReferral(
                new Dictionary<string, object>
                {
                    { "name", "test user" },
                    { "email", "email@example.com" },
                    { "phone", "8888888888" }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(referralUser, Formatting.Indented));
        }
    }
}
