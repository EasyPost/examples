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
    public async Task CreateCustomsItem()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CustomsItem customsItem = await CustomsItem.Create(new Dictionary<string, object>()
        {
            {
                "description", "T-shirt"
            },
            {
                "quantity", 1
            },
            {
                "weight", 5
            },
            {
                "value", 10
            },
            {
                "hs_tariff_number", "123456"
            },
            {
                "origin_country", "US"
            },
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(customsItem, Formatting.Indented));
    }
}
