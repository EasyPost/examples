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

            EasyPost.Parameters.Tracker.Batch parameters = new()
            {
                TrackingCodes = new List<string> { "EZ1000000001", "EZ1000000002" }
            };

            EasyPost.Models.API.TrackerCollection trackerCollection = await client.Tracker.RetrieveBatch(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(trackerCollection, Formatting.Indented));
        }
    }
}
