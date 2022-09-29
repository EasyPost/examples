using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            Tracker tracker = await client.Tracker.Create("USPS", "9400110898825022579493");

            Console.WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
        }
    }
}
