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

            EasyPost.Parameters.CarrierAccount.Create parameters = new()
            {
                Type = "DhlEcsAccount",
                Description = "CA Location DHL eCommerce Solutions Account",
                Credentials = new()
                {
                    { "client_id", "123456" },
                    { "client_secret", "123abc" },
                    { "distribution_center", "USLAX1" },
                    { "pickup_id", "123456" }
                },
                TestCredentials = new()
                {
                    { "client_id", "123456" },
                    { "client_secret", "123abc" },
                    { "distribution_center", "USLAX1" },
                    { "pickup_id", "123456" }
                }
            };

            EasyPost.Models.API.CarrierAccount carrierAccount = await client.CarrierAccount.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
