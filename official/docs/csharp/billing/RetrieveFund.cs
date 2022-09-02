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
    public async Task RetrievePaymentMethods()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        PaymentMethod paymentMethods = await Billing.RetrievePaymentMethods();

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(paymentMethods, Formatting.Indented));
    }
}
