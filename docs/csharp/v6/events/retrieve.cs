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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Models.API.Event @event = await client.Event.Retrieve("evt_...");

            Console.WriteLine(JsonConvert.SerializeObject(@event, Formatting.Indented));
        }
    }
}
