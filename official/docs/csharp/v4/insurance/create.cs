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

            EasyPost.Models.API.Insurance insurance = await client.Insurance.Create(new Dictionary<string, object>()
            {
                {
                    "to_address", new Dictionary<string, object>()
                    {
                        { "id", "adr_..." }
                    }
                },
                {
                    "from_address", new Dictionary<string, object>()
                    {
                        { "id", "adr_..." }
                    }
                },
                { "tracking_code", "9400110898825022579493" },
                { "carrier", "USPS" },
                { "reference", "InsuranceRef1" },
                { "amount", "100.00" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
        }
    }
}
