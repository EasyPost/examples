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
    public async Task RetrieveCarrierTypes()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        List<CarrierType> carrierTypes = await CarrierType.All();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(carrierTypes, Formatting.Indented));
    }
}
