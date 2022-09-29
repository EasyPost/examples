using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Dictionary<string, object> form = new Dictionary<string, object>()
            {
                { "type", "return_packing_slip" },
                { "barcode", "RMA12345678900" },
                {
                    "line_items", new List<Dictionary<string, object>>()
                    {
                        {
                            new Dictionary<string, object>
                            {
                                { "title", "Square Reader" },
                                { "barcode", "855658003251" }
                            }
                        }
                    }
                },
                { "units", 8 }
            };

            await shipment.GenerateForm("return_packing_slip", form);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
