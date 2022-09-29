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

            var client = EasyPost.Client(apiKey);

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            await carrierAccount.Update(new Dictionary<string, object>()
            {
                { "description", "FL Location UPS Account" }
                {
                "credentials",
                new Dictionary<string, object>()
                {
                    { "account_number", "B2B2B2" },
                }
            },
            });

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
