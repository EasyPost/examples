using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));
            EasyPost.Parameters.Shipment.Create parameters = new()
            {
                ToAddress = new EasyPost.Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "5744 Silverton Ave",
                    City = "McKinney",
                    State = "TX",
                    Zip = "75070",
                    Country = "US",
                    Phone = "8573875756",
                    Email = "dr_steve_brule@gmail.com"
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Name = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Zip = "94104",
                    Country = "US",
                    Phone = "4153334445",
                    Email = "support@easypost.com"
                },
                Parcel = new EasyPost.Parameters.Parcel.Create
                {
                    Length = 20.2,
                    Width = 10.9,
                    Height = 5,
                    Weight = 65.9
                },
                RulesetName = "test_ruleset_deliver_by_2",
                PlannedShipDate = "2025-07-03",
                DeliverByDate = "2025-07-06"
            };
            EasyPost.Models.API.Shipment shipment = await client.Shipment.LumaPromise(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
