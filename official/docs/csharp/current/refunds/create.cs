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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            List<Refund> refunds = await Client.Refund.Create(new Dictionary<string, object>
                {
                    { "carrier", Fixtures.Usps },
                    { "tracking_codes", new List<string> { "XXXXX" } }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(refunds, Formatting.Indented));
        }
    }
}
