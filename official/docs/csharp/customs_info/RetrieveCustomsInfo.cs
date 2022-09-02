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
    public async Task RetrieveCustomsInfo()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CustomsInfo customsInfo = await CustomsInfo.Retrieve("cstinfo_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(customsInfo, Formatting.Indented));
    }
}
