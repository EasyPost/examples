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

            Dictionary<string, object> listParams = new Dictionary<string, object>()
            {
                { "page_size", 5 }
            };

            EasyPost.Models.API.PickupCollection pickups = await client.Pickup.All(listParams);

            Console.WriteLine(JsonConvert.SerializeObject(pickups, Formatting.Indented));
        }
    }
}
