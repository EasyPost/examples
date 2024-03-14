using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Rate rate = shipment.LowestRate();

            await shipment.Buy(rate, null, null, "es_...");

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
