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

            EasyPost.Models.API.Webhook webhook = await client.Webhook.Retrieve("hook_...");

            // Update the webhook's settings
            EasyPost.Parameters.Webhook.Update parameters = new()
            {
                Url = "https://example.com/webhook",
            };

            webhook = await client.Webhook.Update(webhook.Id, parameters);

            // Sending an empty parameter set will simply enable a disabled webhook
            parameters = new();

            webhook = await client.Webhook.Update(webhook.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
        }
    }
}
