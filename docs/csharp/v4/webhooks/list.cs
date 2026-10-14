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

            List<EasyPost.Models.API.Webhook> webhooks = await client.Webhook.All();

            Console.WriteLine(JsonConvert.SerializeObject(webhooks, Formatting.Indented));
        }
    }
}
