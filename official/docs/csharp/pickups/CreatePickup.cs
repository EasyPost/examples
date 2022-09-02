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
    public async Task CreatePickup()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Pickup pickup = await Pickup.Create(new Dictionary<string, object>() {
            { "is_account_address", false },
            { "address", new Dictionary<string, object>(){
                { "id,", "adr_..." }
            } },
            { "shipment", new Dictionary<string, object>(){
                { "id,", "shp_..." }
            } },
            { "min_datetime", "2014-10-20 17:10:00" },
            { "max_datetime", "2014-10-21 10:30:00"},
            { "instructions", "Special pickup instructions" },
            { "reference", "my-first-pickup"}
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
    }
}
