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

            Tracker tracker = await Tracker.Create("USPS", "EZ1000000001");

            Console.WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
        }
    }
}
