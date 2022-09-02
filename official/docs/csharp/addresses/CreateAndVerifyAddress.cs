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
    public async Task CreateAndVerifyAddress()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Address address = await Address.CreateAndVerify(
            new Dictionary<string, object> {
                { "street1", "417 MONTGOMERY ST" },
                { "street2", "FLOOR 5" },
                { "city", "SAN FRANCISCO" },
                { "state", "CA" },
                { "zip", "94104" },
                { "country", "US" },
                { "company", "EasyPost" },
                { "phone", "415-123-4567" },
            }
        );

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
    }
}
