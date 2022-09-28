using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            Pickup pickup = await client.Pickup.Create(new Dictionary<string, object>()
            {
                { "reference", "my-first-pickup" },
                { "min_datetime", "2022-10-01 10:30:00" },
                { "max_datetime", "2022-10-01 17:30:00" },
                { "shipment", "shp_..." },
                { "address", "adr_..." },
                { "is_account_address", false },
                { "instructions", "Special pickup instructions" },
            });

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
