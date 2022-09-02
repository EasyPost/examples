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
    public async Task CreateReport()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Report report = await Report.Create("payment_log", new Dictionary<string, object>(){
            { "start_date", "2016-10-01" },
            { "end_date", "2016-10-31" }
        });


        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
    }
}
