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

            List<ApiKey> apiKeys = await client.ApiKey.All();

            Console.WriteLine(JsonConvert.SerializeObject(apiKeys, Formatting.Indented));
        }
    }
}
