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

            EasyPost.Models.API.EventCollection events = await client.EventAll(new Dictionary<string, object>
            {
                { "page_size", 5 }
            });

            Console.WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
        }
    }
}
