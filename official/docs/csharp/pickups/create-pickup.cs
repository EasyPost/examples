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

        Pickup pickup = await Pickup.Create(new Dictionary<string, object>()
        {
            {
                "reference", "my-first-pickup"
            },
            {
                "min_datetime", "2022-10-01 10:30:00"
            },
            {
                "max_datetime", "2022-10-01 17:30:00"
            },
            {
                "shipment", "shp_..."
            },
            {
                "address", "adr_..."
            },
            {
                "is_account_address", false
            },
            {
                "instructions", "Special pickup instructions"
            },

        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
    }
}
