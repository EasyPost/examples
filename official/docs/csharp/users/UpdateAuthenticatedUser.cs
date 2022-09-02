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
    public async Task UpdateAuthenticatedUser()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        User user = await User.RetrieveMe();

        await user.Update(new Dictionary<string, object>() {
            { "recharge_threshold", 50.00 }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
    }
}
