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
    public async Task RetreiveCustomsItem()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CustomsItem customsItem = await CustomsItem.Retrieve("cstitem_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(customsItem, Formatting.Indented));
    }
}
