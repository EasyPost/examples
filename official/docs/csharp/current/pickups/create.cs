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

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Retrieve("shp_...");

            EasyPost.Parameters.Pickup.Create parameters = new()
            {
                Address = new EasyPost.Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                Shipment = shipment,
                Reference = "my-first-pickup",
                MinDatetime = "2022-10-01 10:30:00",
                MaxDatetime = "2022-10-01 17:30:00",
                Instructions = "Special pickup instructions",
                IsAccountAddress = false,
                CarrierAccounts = new List<EasyPost.Models.API.CarrierAccount>
                {
                    new CarrierAccount
                    {
                        Id = "ca_..."
                    }
                }
            };

            EasyPost.Models.API.Pickup pickup = await client.Pickup.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
