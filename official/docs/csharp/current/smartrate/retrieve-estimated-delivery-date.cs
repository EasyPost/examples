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

            Parameters.Shipment.RetrieveEstimatedDeliveryDate parameters = new()
            {
                PlannedShipDate = "2021-01-01",
            };

            List<RateWithEstimatedDeliveryDate> rates = await client.Shipment.RetrieveEstimatedDeliveryDate("shp_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
