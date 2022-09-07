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
    public async Task BuyShipment()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Shipment shipment = await Shipment.Retrieve("shp_...");

        Rate rate = shipment.LowestRate();

        await shipment.Buy(rate, "249.99");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
    }
}
