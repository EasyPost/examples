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
    public async Task CreateShipmentWithOptions()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
            { "parcel", new Dictionary<string, object>() {
                { "id", "prcl_..." }
            } },
            { "to_address", new Dictionary<string, object>(){
                { "id", "adr_..." }
            } },
            { "from_address", new Dictionary<string, object>(){
                { "id", "adr_..." }
            }},
            { "options", new Dictionary<string, object>() {
                { "print_custom_1", "Custom label message" }
            } }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
    }
}
