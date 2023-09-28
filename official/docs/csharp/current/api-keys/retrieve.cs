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

            List<ApiKey> apiKeys = await client.ApiKey.All();

            Console.WriteLine(JsonConvert.SerializeObject(apiKeys, Formatting.Indented));

            // Retrieve API keys for a specific child user
            List<ApiKey> childApiKeys = await client.ApiKey.RetrieveApiKeysForUser("user_...");

            Console.WriteLine(JsonConvert.SerializeObject(childApiKeys, Formatting.Indented));
        }
    }
}
