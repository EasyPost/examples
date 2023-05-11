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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Shipment shipment = await Shipment.Retrieve("shp_...");
            await shipment.Buy(shipment.LowestRate(), withCarbonOffset: true);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
