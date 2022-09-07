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
    public async Task ManifestBatch()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Batch batch = await Batch.Retrieve("batch_...");

        await batch.GenerateScanForm();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
    }
}
