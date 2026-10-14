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
                    Name = "Tim Canterbury",
                    Company = "Wernham Hogg",
                    Street1 = "118 Clippenham Lane",
                    City = "Slough",
                    Country = "GB",
                    Zip = "SL15BE"
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Company = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Zip = "94104",
                    Phone = "415-528-7555"
                },
                Parcel = new EasyPost.Parameters.Parcel.Create
                {
                    Length = 9,
                    Width = 6,
                    Height = 3,
                    Weight = 20
                },
                CustomsInfo = new EasyPost.Parameters.CustomsInfo.Create
                {
                    EelPfc = "NOEEI 30.37(a)",
                    CustomsCertify = true,
                    CustomsSigner = "Steve Brule",
                    ContentsType = "merchandise",
                    ContentsExplanation = "",
                    RestrictionType = "none",
                    CustomsItems =
                    [
                        new EasyPost.Parameters.CustomsItem.Create
                        {
                            Description = "T-shirt",
                            Quantity = 2,
                            Weight = 11,
                            Value = 23,
                            HsTariffNumber = "654321",
                            OriginCountry = "US"
                        }
                    ]
                }
            };

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
