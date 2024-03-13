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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Batch batch = await client.Batch.Retrieve("batch_...");

            Parameters.Batch.RemoveShipments parameters = new()
            {
                Shipments = new List<Shipment> { shipment },
            };

            batch = await client.Batch.RemoveShipments(batch.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
