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

            Parameters.Shipment.RetrieveEstimatedDeliveryDate parameters = new()
            {
                PlannedShipDate = "2021-01-01",
            };

            List<RateWithEstimatedDeliveryDate> rates = await client.Shipment.RetrieveEstimatedDeliveryDate(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
