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
    public async Task UpdateCarrierAccount()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

        await carrierAccount.Update(new Dictionary<string, object>() {
            { "credentials", new Dictionary<string, object>(){
                { "pickup_id", "abc123" },
            } },
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
    }
}
