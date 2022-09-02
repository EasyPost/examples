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
    public async Task RetrieveBatchList()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        BatchCollection batchCollection = await Batch.All(new Dictionary<string, object>
        {
            {
                "page_size", 5
            }
        });

        List<Batch> batches = batchCollection.batches;

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(batches, Formatting.Indented));
    }
}
