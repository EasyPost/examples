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

            EasyPost.Parameters.Refund.Create parameters = new()
            {
                Carrier = "USPS",
                TrackingCodes = new List<string> { "EZ1000000001" }
            };

            List<EasyPost.Models.API.Refund> refunds = await client.Refund.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refunds, Formatting.Indented));
        }
    }
}
