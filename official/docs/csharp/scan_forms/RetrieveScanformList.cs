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
    public async Task RetrieveAllScanForms()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        ScanFormCollection scanFormCollection = await ScanForm.All(new Dictionary<string, object>()
        {
            {
                "page_size", 5
            }
        });


        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(scanFormCollection, Formatting.Indented));
    }
}
