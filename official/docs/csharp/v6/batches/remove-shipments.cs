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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Retrieve("shp_...");

            EasyPost.Parameters.Batch.RemoveShipments parameters = new()
            {
                Shipments = new List<EasyPost.Parameters.IShipmentParameter> { shipment },
            };

            EasyPost.Models.API.Batch batch = await client.Batch.RemoveShipments("batch_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
