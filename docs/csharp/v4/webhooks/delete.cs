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

            bool success = await webhook.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
