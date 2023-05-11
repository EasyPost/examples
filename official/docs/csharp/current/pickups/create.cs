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

            Address address = await client.Address.Retrieve("adr_...");
            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Parameters.Pickup.Create parameters = new()
            {
                Address = address,
                Shipment = shipment,
                Reference = "my-first-pickup",
                MinDatetime = "2022-10-01 10:30:00",
                MaxDatetime = "2022-10-01 17:30:00",
                Instructions = "Special pickup instructions",
                IsAccountAddress = false
            };

            Pickup pickup = await client.Pickup.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
