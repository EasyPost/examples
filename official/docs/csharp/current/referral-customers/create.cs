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
            EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

            ReferralCustomer referralUser = await Partner.CreateReferral(
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
