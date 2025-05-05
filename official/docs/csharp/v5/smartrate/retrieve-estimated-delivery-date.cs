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

            EasyPost.Parameters.Shipment.RetrieveEstimatedDeliveryDate parameters = new()
            {
                PlannedShipDate = "2021-01-01",
            };

            List<EasyPost.Models.API.RateWithEstimatedDeliveryDate> rates = await client.Shipment.RetrieveEstimatedDeliveryDate(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
