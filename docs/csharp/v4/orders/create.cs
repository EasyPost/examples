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

            EasyPost.Models.API.Order order = await client.Order.Create(
                new Dictionary<string, object>()
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
                        "shipments", new List<Dictionary<string, object>>()
                        {
                            {
                                new Dictionary<string, object>
                                {
                                    {
                                        "parcel", new Dictionary<string, object>()
                                        {
                                            { "weight", 10.2 }
                                        }
                                    }
                                }
                            },
                            {
                                new Dictionary<string, object>
                                {
                                    {
                                        "parcel", new Dictionary<string, object>()
                                        {
                                            { "predefined_package", "FedExBox" },
                                            { "weight", 17.5 }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
