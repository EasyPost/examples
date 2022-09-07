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
    public async Task CreateBatch()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Batch batch = await Batch.Create(new Dictionary<string, object>()
        {
            {
                "shipments", new List<string>()
                {
                    "shp_...",
                    "shp_...",
                }
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
    }
}
