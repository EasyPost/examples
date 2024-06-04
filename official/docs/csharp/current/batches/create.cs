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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Parameters.Batch.Create parameters = new()
            {
                Shipments = new List<IShipmentParameter>()
                {
                    shipment
                }
            };

            Batch batch = await client.Batch.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
