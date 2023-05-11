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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Tracker tracker = await client.Tracker.Create("USPS", "EZ1000000001");

            Console.WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
        }
    }
}
