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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            EasyPost.Models.API.Parcel parcel = await client.Parcel.Create(
              new EasyPost.Parameters.Parcel.Create
              {
                  PredefinedPackage = "Parcel",
                  Weight = 28
              }
            );

            EasyPost.Models.API.Shipment shipment = await client.Shipment.Create(
                new EasyPost.Parameters.Shipment.Create
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
