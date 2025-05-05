using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.Webhook.Create parameters = new()
            {
                Url = "example.com",
                Secret = "ABC123",
            };

            EasyPost.Models.API.Webhook webhook = await client.Webhook.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
        }
    }
}
