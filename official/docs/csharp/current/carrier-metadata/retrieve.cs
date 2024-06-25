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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            // Request all metadata for all carriers
            List<Carrier> carrierMetadata = await client.CarrierMetadata.Retrieve();
            Console.WriteLine(JsonConvert.SerializeObject(carrierMetadata, Formatting.Indented));

            // Request specific metadata for specific carriers
            Parameters.CarrierMetadata.Retrieve parameters = new()
            {
                Carriers = new List<string> { "UPS", "USPS" },
                Types = new List<CarrierMetadataType> { CarrierMetadataType.ServiceLevels, CarrierMetadataType.PredefinedPackages },
            };

            List<Carrier> carrierMetadata = await client.CarrierMetadata.Retrieve(parameters);
            Console.WriteLine(JsonConvert.SerializeObject(carrierMetadata, Formatting.Indented));
        }
    }
}
