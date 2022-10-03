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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            EasyPost.ClientManager.SetCurrent(apiKey);

            Shipment shipment = await Shipment.Retrieve("shp_...");

            Rate rate = shipment.LowestRate();

            await shipment.Buy(rate, null, null, "es_...");

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
