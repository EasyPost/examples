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
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Company = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "Floor 5",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                Parcel = new EasyPost.Parameters.Parcel.Create
                {
                    Length = 8,
                    Width = 6,
                    Height = 5,
                    Weight = 10
                },
                CustomsInfo = new EasyPost.Parameters.CustomsInfo.Create
                {
                    // ...
                },
                TaxIdentifiers = new List<EasyPost.Parameters.TaxIdentifiers.Create>
                {
                    new()
                    {
                        Entity = "SENDER",
                        TaxId = "GB123456789",
                        TaxIdType = "EORI",
                        IssuingCountry = "GB"
                    }
                }
            };

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
