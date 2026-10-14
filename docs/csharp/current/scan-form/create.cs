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

            EasyPost.Parameters.ScanForm.Create parameters = new()
            {
                Shipments = new List<EasyPost.Parameters.IShipmentParameter>
                {
                    shipment
                }
            };

            EasyPost.Models.API.ScanForm scanForm = await client.ScanForm.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(scanForm, Formatting.Indented));
        }
    }
}
