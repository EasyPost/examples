using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Parameters.Shipment.Create shipmentParameters = new()
            {
                ToAddress = new Parameters.Address.Create
                {
                    Id = "adr_..."
                },
                FromAddress = new Parameters.Address.Create
                {
                    Id = "adr_..."
                },
                Parcel = new Parameters.Parcel.Create
                {
                    Id = "prcl_..."
                },
                Service = "First",
                Carrier = "USPS",
                CarrierAccountIds = new List<string> { "ca_..." }
            };

            Parameters.Batch.Create parameters = new()
            {
                Shipments = new List<IShipmentParameter>()
                {
                    shipmentParameters
                }
            };

            Batch batch = await client.Batch.Create(parameters);

            batch = await client.Batch.Buy(batch.Id);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
