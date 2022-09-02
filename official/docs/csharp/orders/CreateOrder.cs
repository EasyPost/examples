using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples;

public class Examples
{
    [Fact]
    public async Task CreateOrder()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Order order = await Order.Create(
            new Dictionary<string, object>()
            {
                {
                    "to_address", new Dictionary<string, object>()
                    {
                        {
                            "id", "adr_..."
                        }
                    }
                },
                {
                    "from_address", new Dictionary<string, object>()
                    {
                        {
                            "id", "adr_..."
                        }
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
                                        {
                                            "weight", 10.2
                                        }
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
                                        {
                                            "weight", 17.5
                                        },
                                        {
                                            "predefined_package", "FedExBox"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
    }
}
