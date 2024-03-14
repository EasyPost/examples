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

            List<ApiKey> apiKeys = await client.ApiKey.All();

            Console.WriteLine(JsonConvert.SerializeObject(apiKeys, Formatting.Indented));
        }
    }
}
