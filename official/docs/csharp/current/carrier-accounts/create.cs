using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            CarrierAccount carrierAccount = await client.CarrierAccount.Create(new Dictionary<string, object>()
            {
                { "type", "DhlEcsAccount" },
                { "description", "CA Location DHL eCommerce Solutions Account" },
                {
                    "credentials", new Dictionary<string, object>
                    {
                        { "client_id", "123456" },
                        { "client_secret", "123abc" },
                        { "distribution_center", "USLAX1" },
                        { "pickup_id", "123456" }
                    }
                },
                {
                    "test_credentials", new Dictionary<string, object>
                    {
                        { "client_id", "123456" },
                        { "client_secret", "123abc" },
                        { "distribution_center", "USLAX1" },
                        { "pickup_id", "123456" }
                    }
                },
            });

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
