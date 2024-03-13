using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Parameters.Shipment.Create parameters = new()
            {
                ToAddress = new Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                FromAddress = new Parameters.Address.Create
                {
                    Company = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "Floor 5",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                Parcel = new Parameters.Parcel.Create
                {
                    Length = 8,
                    Width = 6,
                    Height = 5,
                    Weight = 10
                },
                CustomsInfo = new Parameters.CustomsInfo.Create
                {
                    ...
                },
                TaxIdentifiers = new List<Parameters.TaxIdentifiers.Create>
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

            Shipment shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
