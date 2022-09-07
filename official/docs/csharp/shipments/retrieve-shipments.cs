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
    public async Task RetrieveAllShipments()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Dictionary<string, object> listParams = new Dictionary<string, object>()
        {
            {
                "page_size", 5
            }
        };

        ShipmentCollection shipmentCollection = await Shipment.All(listParams);

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipmentCollection, Formatting.Indented));
    }
}
