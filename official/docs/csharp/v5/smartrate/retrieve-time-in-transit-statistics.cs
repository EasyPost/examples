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

            List<EasyPost.Models.API.SmartRate> smartRates = await client.Shipment.GetSmartRates(shipment.Id);

            Console.WriteLine(JsonConvert.SerializeObject(smartRates, Formatting.Indented));
        }
    }
}
