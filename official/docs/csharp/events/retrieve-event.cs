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
    public async Task RetrieveEvent()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Event @event = await Event.Retrieve("event_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(@event, Formatting.Indented));
    }
}
