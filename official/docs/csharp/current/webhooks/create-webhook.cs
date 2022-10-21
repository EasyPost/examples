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

            Webhook webhook = await client.Webhook.Create(
                new Dictionary<string, object>()
                {
                    { "url", "example.com" }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
        }
    }
}
