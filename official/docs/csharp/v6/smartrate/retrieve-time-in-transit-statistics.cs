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

            List<EasyPost.Models.API.SmartRate> smartRates = await client.Shipment.GetSmartRates("shp_...");

            Console.WriteLine(JsonConvert.SerializeObject(smartRates, Formatting.Indented));
        }
    }
}
