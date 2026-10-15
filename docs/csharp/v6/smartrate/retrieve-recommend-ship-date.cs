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

            EasyPost.Parameters.Shipment.RecommendShipDateForShipment parameters = new()
            {
                DesiredDeliveryDate = "2024-07-18",
            };

            List<EasyPost.Models.API.RecommendShipDateForShipmentResult> rates = await client.Shipment.RecommendShipDate("shp_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
