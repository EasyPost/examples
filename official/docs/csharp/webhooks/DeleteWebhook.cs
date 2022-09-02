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
    public async Task DeleteWebhook()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Webhook webhook = await Webhook.Retrieve("hook_...");

        bool success = await webhook.Delete();

        new TestOutputHelper().WriteLine(success.ToString());
    }
}
