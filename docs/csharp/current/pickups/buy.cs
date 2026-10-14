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

            EasyPost.Parameters.Pickup.Buy parameters = new("UPS", "Same-Day Pickup");

            EasyPost.Models.API.Pickup pickup = await client.Pickup.Buy("pickup_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
