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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            // Shipment has to be purchased before forms can be generated
            EasyPost.Models.API.Shipment shipment = await client.Shipment.Retrieve("shp_...");

            EasyPost.Parameters.Shipment.GenerateForm parameters = new()
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
