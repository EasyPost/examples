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

            EasyPost.Parameters.Shipment.RetrieveEstimatedDeliveryDate parameters = new()
            {
                PlannedShipDate = "2021-01-01",
            };

            List<EasyPost.Models.API.RateWithEstimatedDeliveryDate> rates = await client.Shipment.RetrieveEstimatedDeliveryDate("shp_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
