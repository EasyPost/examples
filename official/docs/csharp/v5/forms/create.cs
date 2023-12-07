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

            // Shipment has to be purchased before forms can be generated
            Shipment shipment = await client.Shipment.Retrieve("shp_...");

            Parameters.Shipment.GenerateForm parameters = new()
            {
                Type = "return_packing_slip",
                Data = new()
                {
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
                }
            };

            shipment = await client.Shipment.GenerateForm(shipment.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
