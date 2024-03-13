using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Parcel parcel = await client.Parcel.Create(
              new Parameters.Parcel.Create
              {
                  PredefinedPackage = "Parcel",
                  Weight = 28
              }
            );

            Shipment shipment = await client.Shipment.Create(
                new Parameters.Shipment.Create
                {
                    ToAddress = toAddress,
                    FromAddress = fromAddress,
                    Parcel = parcel
                }
            );

            await client.shipment.Buy(shipment.Id, shipment.LowestRate());
        }
    }
}
