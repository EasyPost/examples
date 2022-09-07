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
    public async Task CreateForm()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Shipment shipment = await Shipment.Retrieve("shp_...");

        Dictionary<string, object> form = new Dictionary<string, object>()
        {
            {
                "type", "return_packing_slip"
            },
            {
                "barcode", "RMA12345678900"
            },
            {
                "line_items", new List<Dictionary<string, object>>()
                {
                    {
                        new Dictionary<string, object>
                        {
                            {
                                "title", "Square Reader"
                            },
                            {
                                "barcode", "855658003251"
                            }
                        }
                    }
                }
            },
            {
                "units", 8
            }
        };

        await shipment.GenerateForm("return_packing_slip", form);

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
    }
}
