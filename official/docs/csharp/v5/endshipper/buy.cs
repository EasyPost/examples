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

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Retrieve("shp_...");

            EasyPost.Models.API.Rate rate = shipment.LowestRate();

            EasyPost.Parameters.Shipment.Buy parameters = new(rate)
            {
                EndShipperId = "es_...",
            };

            shipment = await client.Shipment.Buy(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
