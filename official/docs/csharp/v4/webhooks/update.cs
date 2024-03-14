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

            Webhook webhook = await client.Webhook.Retrieve("hook_...");

            await webhook.Update();

            Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
        }
    }
}
