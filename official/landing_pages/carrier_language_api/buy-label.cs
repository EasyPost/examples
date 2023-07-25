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

            Parcel parcel = await client.Parcel.Create(new Dictionary<string, object>() {
                { "predefined_package", "Parcel" },
                { "weight", 28 }
            });

            Shipment shipment = await client.Shipment.Create(new Dictionary<string, object>() {
                { "to_address", toAddress },
                { "from_address", fromAddress },
                { "parcel", parcel }
            });

            await client.shipment.Buy(shipment.LowestRate());
        }
    }
}
