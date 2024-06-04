using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            List<SmartRate> smartRates = await client.Shipment.GetSmartRates(shipment.Id);

            Console.WriteLine(JsonConvert.SerializeObject(smartRates, Formatting.Indented));
        }
    }
}
