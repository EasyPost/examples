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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Address toAddress = await client.Address.Retrieve("adr_...");
            Address fromAddress = await client.Address.Retrieve("adr_...");
            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Parameters.Order.Create parameters = new()
            {
                ToAddress = toAddress,
                FromAddress = fromAddress,
                Shipments = new List<Shipment>() { shipment }
            };

            Order order = await client.Order.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
