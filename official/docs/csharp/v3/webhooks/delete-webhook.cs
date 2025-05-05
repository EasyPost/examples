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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            Webhook webhook = await Webhook.Retrieve("hook_...");

            bool success = await webhook.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
