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

            Dictionary<string, object> fromAddress = new Dictionary<string, object>() {
                { "name", "Dr. Steve Brule" },
                { "street1", "417 Montgomery Street" },
                { "street2", "5th Floor" },
                { "city", "San Francisco" },
                { "state", "CA" },
                { "country", "US" },
                { "zip", "94104" }
            };

            Dictionary<string, object> toAddress = new Dictionary<string, object>() {
                { "company", "EasyPost" },
                { "street1", "417 Montgomery Street" },
                { "street2", "Floor 5" },
                { "city", "San Francisco" },
                { "state", "CA" },
                { "country", "US" },
                { "zip", "94104" }
            };

            Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
                { "parcel", new Dictionary<string, object>() {
                    { "length", 8 }, { "width", 6 }, { "height", 5 }, { "weight", 10 }
                } },
                { "to_address", toAddress },
                { "from_address", fromAddress },
                { "reference", "ShipmentRef" }
            }, withCarbonOffset: true);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
