using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            await carrierAccount.Update(new Dictionary<string, object>()
            {
                { "description", "FL Location DHL eCommerce Solutions Account" },
                {
                    "credentials", new Dictionary<string, object>()
                    {
                        { "pickup_id", "abc123" },
                    }
                },
            });

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
