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

            EasyPost.Parameters.SmartRate.RecommendShipDateForZipPair recommendShipDateForZipPairParameters = new()
            {
                OriginPostalCode = address1Parameters.Zip,
                DestinationPostalCode = address2Parameters.Zip,
                DesiredDeliveryDate = Fixtures.DesiredDeliveryDate,
                Carriers = ["USPS"],
            };

            EasyPost.Models.API.RecommendShipDateForZipPairResult results = await client.SmartRate.RecommendShipDate(recommendShipDateForZipPairParameters);

            Console.WriteLine(JsonConvert.SerializeObject(results, Formatting.Indented));
        }
    }
}
