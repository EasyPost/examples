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

            EasyPost.Parameters.Webhook.Create parameters = new()
            {
                Secret = "ABC123",
                CustomHeaders = new EasyPost.Models.API.WebhookCustomHeader { Name = "X-Header-Name", Value = "header_value" }
            };

            EasyPost.Models.API.Webhook webhook = await client.Webhook.Update("hook_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
        }
    }
}
