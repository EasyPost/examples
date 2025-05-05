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

            // Request all metadata for all carriers
            List<EasyPost.Models.API.Carrier> carrierMetadata = await client.CarrierMetadata.Retrieve();

            Console.WriteLine(JsonConvert.SerializeObject(carrierMetadata, Formatting.Indented));

            // Request specific metadata for specific carriers
            EasyPost.Parameters.CarrierMetadata.Retrieve parameters = new()
            {
                Carriers = new List<string> { "UPS", "USPS" },
                Types = new List<EasyPost.Models.API.CarrierMetadataType> { CarrierMetadataType.ServiceLevels, CarrierMetadataType.PredefinedPackages },
            };

            List<EasyPost.Models.API.Carrier> carrierMetadata = await client.CarrierMetadata.Retrieve(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(carrierMetadata, Formatting.Indented));
        }
    }
}
