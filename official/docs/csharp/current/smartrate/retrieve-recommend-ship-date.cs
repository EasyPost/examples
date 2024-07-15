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

            Parameters.Shipment.RecommendShipDateForShipment parameters = new()
            {
                DesiredDeliveryDate = "2024-07-18",
            };

            List<RecommendShipDateForShipmentResult> rates = await client.Shipment.RetrieveEstimatedDeliveryDate("shp_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
