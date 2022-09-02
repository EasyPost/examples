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
    public async Task RetrieveAddress()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Address address = await Address.Retrieve("adr_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
    }
}
