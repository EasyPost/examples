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
    public async Task CreateWebhook()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Webhook webhook = await Webhook.Create(
            new Dictionary<string, object>() {
                { "url", "example.com" }
            }
        );

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
    }
}
