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
    public async Task UpdateWebhook()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Webhook webhook = await Webhook.Retrieve("hook_...");

        await webhook.Update();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
    }
}
