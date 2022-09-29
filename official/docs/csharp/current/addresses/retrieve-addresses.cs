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

            AddressCollection addressCollection = await client.Address.All(new Dictionary<string, object>
                {
                    { "page_size", 5 }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(addressCollection, Formatting.Indented));
        }
    }
}
