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

            EasyPost.Models.API.Address address = await client.Address.Create(
                new Dictionary<string, object>
                {
                    { "street1", "417 MONTGOMERY ST" },
                    { "street2", "FLOOR 5" },
                    { "city", "SAN FRANCISCO" },
                    { "state", "CA" },
                    { "zip", "94104" },
                    { "country", "US" },
                    { "company", "EasyPost" },
                    { "phone", "415-123-4567" },
                    { "verify", true }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
