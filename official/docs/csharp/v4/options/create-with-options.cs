using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Shipment shipment = await client.Shipment.Create(new Dictionary<string, object>()
            {
                {
                    "to_address", new Dictionary<string, object>()
                    {
                        { "id", "adr_..." }
                    }
                },
                {
                    "from_address", new Dictionary<string, object>()
                    {
                        { "id", "adr_..." }
                    }
                },
                {
                    "parcel", new Dictionary<string, object>()
                    {
                        { "id", "prcl_..." }
                    }
                },
                {
                    "options", new Dictionary<string, object>()
                    {
                        { "print_custom_1", "Custom label message" }
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
