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
    public async Task CreateParcel()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Parcel parcel = await Parcel.Create(new Dictionary<string, object>() {
            { "length", 20.2 },
            { "width", 10.9 },
            { "height", 5 },
            { "weight", 65.9 }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
    }
}
