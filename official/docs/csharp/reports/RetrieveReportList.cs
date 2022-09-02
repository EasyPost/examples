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
    public async Task RetrieveAllReports()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        ReportCollection reportCollection = await Report.All("payment_log", new Dictionary<string, object>()
        {
            {
                "page_size", 4
            },
            {
                "start_date", "2016-01-02"
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(reportCollection, Formatting.Indented));
    }
}
