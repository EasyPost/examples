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

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Parameters.Shipment.GenerateLabel parameters = new()
            {
                FileFormat = "ZPL",
            };

            shipment = await client.Shipment.GenerateLabel(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
