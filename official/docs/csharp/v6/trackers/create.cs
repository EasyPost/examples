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

            EasyPost.Parameters.Tracker.Create parameters = new()
            {
                TrackingCode = "EZ1000000001",
                Carrier = "USPS"
            };

            EasyPost.Models.API.Tracker tracker = await client.Tracker.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
        }
    }
}
