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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Pickup pickup = await client.Pickup.Retrieve("pickup_...");

            Parameters.Pickup.Buy parameters = new("UPS", "Same-Day Pickup");

            pickup = await client.Pickup.Buy(pickup.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
