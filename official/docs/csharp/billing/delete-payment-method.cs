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
    public async Task DeletePaymentMethod()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        bool success = await Billing.DeletePaymentMethod(PaymentMethod.Priority.Primary);

        new TestOutputHelper().WriteLine(success.ToString());
    }
}
