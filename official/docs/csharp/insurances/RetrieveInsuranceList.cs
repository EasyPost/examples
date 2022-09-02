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
    public async Task RetrieveAllInsurance()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        InsuranceCollection insuranceCollection = await Insurance.All(new Dictionary<string, object>(){
            { "page_size", 5 }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(insuranceCollection, Formatting.Indented));
    }
}
