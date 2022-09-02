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
    public async Task RetrieveAllEvents()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        EventCollection events = await Event.All(new Dictionary<string, object>
        {
            {
                "page_size", 5
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
    }
}
