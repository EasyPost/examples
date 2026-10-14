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

            EasyPost.Models.API.CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            EasyPost.Parameters.CarrierAccount.Update parameters = new()
            {
                Description = "FL Location DHL eCommerce Solutions Account",
                Credentials = new()
                {
                    { "pickup_id", "abc123" }
                },
            };

            carrierAccount = await client.CarrierAccount.Update(carrierAccount.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
