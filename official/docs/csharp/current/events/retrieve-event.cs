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

            Event @event = await client.EventRetrieve("event_...");

            Console.WriteLine(JsonConvert.SerializeObject(@event, Formatting.Indented));
        }
    }
}
