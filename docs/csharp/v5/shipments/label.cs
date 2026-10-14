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

            EasyPost.Parameters.Shipment.GenerateLabel parameters = new()
            {
                FileFormat = "ZPL",
            };

            shipment = await client.Shipment.GenerateLabel(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
