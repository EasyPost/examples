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
    public async Task DeleteCarrierAccount()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

        bool success = await carrierAccount.Delete();

        new TestOutputHelper().WriteLine(success.ToString());
    }
}
