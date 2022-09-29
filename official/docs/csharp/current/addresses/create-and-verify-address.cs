using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            Address address = await client.Address.CreateAndVerify(
                new Dictionary<string, object>
                {
                    { "street1", "417 Montgomery Street" },
                    { "street2", "FL 5" },
                    { "city", "San Francisco" },
                    { "state", "CA" },
                    { "zip", "94104" },
                    { "country", "US" },
                    { "company", "EasyPost" },
                    { "phone", "415-123-4567" },
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
