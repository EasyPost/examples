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

            EasyPost.Parameters.Shipment.Create shipmentParameters = new()
            {
                ToAddress = new EasyPost.Parameters.Address.Create
                {
                    Id = "adr_..."
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Id = "adr_..."
                },
                Parcel = new EasyPost.Parameters.Parcel.Create
                {
                    Id = "prcl_..."
                },
                Service = "First",
                Carrier = "USPS",
                CarrierAccountIds = new List<string> { "ca_..." }
            };

            EasyPost.Parameters.Batch.Create parameters = new()
            {
                Shipments = new List<EasyPost.Parameters.IShipmentParameter>()
                {
                    shipmentParameters
                }
            };

            EasyPost.Models.API.Batch batch = await client.Batch.Create(parameters);

            EasyPost.Models.API.Batch batch = await client.Batch.Buy(batch.Id);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
