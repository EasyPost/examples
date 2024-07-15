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

            Parameters.SmartRate.RecommendShipDateForZipPair recommendShipDateForZipPairParameters = new()
            {
                OriginPostalCode = address1Parameters.Zip,
                DestinationPostalCode = address2Parameters.Zip,
                DesiredDeliveryDate = Fixtures.DesiredDeliveryDate,
                Carriers = ["USPS"],
            };

            RecommendShipDateForZipPairResult results = await client.SmartRate.RecommendShipDate(recommendShipDateForZipPairParameters);

            Console.WriteLine(JsonConvert.SerializeObject(results, Formatting.Indented));
        }
    }
}
