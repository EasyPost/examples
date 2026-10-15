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

            // Retrieve all API keys including children
            List<EasyPost.Models.API.ApiKey> apiKeys = await client.ApiKey.All();

            Console.WriteLine(JsonConvert.SerializeObject(apiKeys, Formatting.Indented));

            // Retrieve API keys for a specific child user
            List<EasyPost.Models.API.ApiKey> childApiKeys = await client.ApiKey.RetrieveApiKeysForUser("user_...");

            Console.WriteLine(JsonConvert.SerializeObject(childApiKeys, Formatting.Indented));
        }
    }
}
