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

            EasyPost.Models.API.Shipment shipment = await client.Shipment.GenerateForm("shp_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
