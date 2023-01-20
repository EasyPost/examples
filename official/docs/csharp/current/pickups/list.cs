using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY");

            EasyPost.Client client = new EasyPost.Client(apiKey);

            EasyPost.Models.API.PickupCollection pickups = await client.Pickup.All();

            Console.WriteLine(JsonConvert.SerializeObject(pickups, Formatting.Indented));
        }
    }
}

