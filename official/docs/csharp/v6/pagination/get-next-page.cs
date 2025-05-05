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

            // Get first page of results
            EasyPost.Parameters.Shipment.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.ShipmentCollection shipmentCollection = await client.Shipment.All(parameters);

            // Provide the previous results page to move onto the next page
            EasyPost.Models.API.ShipmentCollection nextPage = await client.Shipment.GetNextPage(shipmentCollection);

            Console.WriteLine(JsonConvert.SerializeObject(nextPage, Formatting.Indented));
        }
    }
}
