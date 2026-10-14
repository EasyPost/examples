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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.CarrierAccount.Update parameters = new()
            {
                Description = "FL Location DHL eCommerce Solutions Account",
                Credentials = new()
                {
                    { "pickup_id", "abc123" }
                },
            };

            EasyPost.Models.API.carrierAccount = await client.CarrierAccount.Update("ca_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
        }
    }
}
