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

            EventCollection events = await client.EventAll(new Dictionary<string, object>
            {
                { "page_size", 5 }
            });

            Console.WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
        }
    }
}
