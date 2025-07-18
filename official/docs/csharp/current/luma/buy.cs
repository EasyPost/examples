using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Retrieve("shp_...");

            shipment = await client.Shipment.BuyLuma(
                shipment.Id,
                rulesetName: "ruleset_name",
                plannedShipDate: "2025-07-18",
                deliverByDate: "2025-07-20"
            );
            
            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
