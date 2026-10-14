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

            EasyPost.Parameters.SmartRate.EstimateDeliveryDateForZipPair estimateDeliveryDateForZipPairParameters = new()
            {
                OriginPostalCode = address1Parameters.Zip,
                DestinationPostalCode = address2Parameters.Zip,
                PlannedShipDate = Fixtures.PlannedShipDate,
                Carriers = ["USPS"],
            };

            EasyPost.Models.API.EstimateDeliveryDateForZipPairResult results = await client.SmartRate.EstimateDeliveryDate(estimateDeliveryDateForZipPairParameters);

            Console.WriteLine(JsonConvert.SerializeObject(results, Formatting.Indented));
        }
    }
}
