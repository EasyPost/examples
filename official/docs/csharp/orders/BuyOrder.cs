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
    public async Task BuyOrder()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Order order = await Order.Retrieve("order_...");

        await order.Buy("FedEx", "FEDEX_GROUND");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
    }
}
