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

            Shipment retrievedShipment = await client.Shipment.Retrieve("shp_...");

            Rate rate = retrievedShipment.LowestRate();

            Parameters.Shipment.Buy parameters = new(rate);

            shipment = await client.Shipment.Buy(retrievedShipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
