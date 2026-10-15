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

            List<EasyPost.Models.API.Refund> refunds = await Client.Refund.Create(new Dictionary<string, object>
                {
                    { "carrier", Fixtures.Usps },
                    { "tracking_codes", new List<string> { "EZ1000000001" } }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(refunds, Formatting.Indented));
        }
    }
}
