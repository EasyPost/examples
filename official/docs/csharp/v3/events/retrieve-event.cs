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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            Event @event = await Event.Retrieve("evt_...");

            Console.WriteLine(JsonConvert.SerializeObject(@event, Formatting.Indented));
        }
    }
}
