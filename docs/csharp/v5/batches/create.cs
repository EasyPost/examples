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

            EasyPost.Parameters.Batch.Create parameters = new()
            {
                Shipments = new List<EasyPost.Models.API.Shipment>()
                {
                    shipment
                }
            };

            EasyPost.Models.API.Batch batch = await client.Batch.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
