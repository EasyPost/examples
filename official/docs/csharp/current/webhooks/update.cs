using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Webhook webhook = await client.Webhook.Retrieve("hook_...");

            // Update the webhook's settings
            Parameters.Webhook.Update parameters = new()
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
