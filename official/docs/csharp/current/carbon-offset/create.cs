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
            Parcel parcel = await client.Parcel.Retrieve("prcl_...");

            Parameters.Shipment.Create parameters = new()
            {
                Parcel = parcel,
                ToAddress = toAddress,
                FromAddress = fromAddress,
                Reference = "ShipmentRef",
                CarbonOffset = true
            };

            Shipment shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
