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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            List<Refund> refunds = await Client.Refund.Create(new Dictionary<string, object>
                {
                    { "carrier", Fixtures.Usps },
                    { "tracking_codes", new List<string> { "EZ1000000001" } }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(refunds, Formatting.Indented));
        }
    }
}
