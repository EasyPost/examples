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
    public async Task UpdateChildUser()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        User childUser = await User.Retrieve("user_..");

        await childUser.Update(new Dictionary<string, object>() {
            { "name", "Test Child" }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(childUser, Formatting.Indented));
    }
}
