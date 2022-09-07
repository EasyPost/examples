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
    public async Task RetreiveAllApiKeys()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        List<ApiKey> apiKeys = await ApiKey.All();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(apiKeys, Formatting.Indented));
    }
}
