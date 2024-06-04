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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            // Create a shipment using all data in one API call

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
                }
            };

            Shipment shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));

            // Create a shipment using existing addresses, parcel, and customs info

            Address toAddress = await client.Address.Retrieve("adr_...");
            Address fromAddress = await client.Address.Retrieve("adr_...");
            Parcel parcel = await client.Parcel.Retrieve("prcl_...");
            CustomsInfo customsInfo = await client.CustomsInfo.Retrieve("cstinfo_...");

            parameters = new()
            {
                ToAddress = toAddress,
                FromAddress = fromAddress,
                Parcel = parcel,
                CustomsInfo = customsInfo
            };

            shipment = await client.Shipment.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(shipmentWithIds, Formatting.Indented));
        }
    }
}
