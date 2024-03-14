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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            Parameters.CarrierAccount.Update parameters = new()
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
