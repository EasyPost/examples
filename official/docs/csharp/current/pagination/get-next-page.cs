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

            // Get first page of results
            Parameters.Shipment.All parameters = new()
            {
                PageSize = 5
            };

            ShipmentCollection shipmentCollection = await client.Shipment.All(parameters);

            // Provide the previous results page to move onto the next page
            ShipmentCollection nextPage = await client.Shipment.GetNextPage(shipmentCollection)

            Console.WriteLine(JsonConvert.SerializeObject(nextPage, Formatting.Indented));
        }
    }
}
