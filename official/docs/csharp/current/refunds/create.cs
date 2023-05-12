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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Parameters.Refund.Create parameters = new()
            {
                Carrier = "USPS",
                TrackingCodes = new List<string> { "EZ1000000001" }
            };

            List<Refund> refunds = await client.Refund.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refunds, Formatting.Indented));
        }
    }
}
