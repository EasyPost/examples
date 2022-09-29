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

            Dictionary<string, object> listParams = new Dictionary<string, object>()
            {
                { "page_size", 5 }
            };

            TrackerCollection trackerCollection = await client.Tracker.All(listParams);

            Console.WriteLine(JsonConvert.SerializeObject(trackerCollection, Formatting.Indented));
        }
    }
}
