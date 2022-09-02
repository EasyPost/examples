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
    public async Task RetrieveCarrierAccountList()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        List<CarrierAccount> carrierAccounts = await CarrierAccount.All();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(carrierAccounts, Formatting.Indented));
    }
}
