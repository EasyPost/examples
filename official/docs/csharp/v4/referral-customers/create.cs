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
