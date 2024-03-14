using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Pickup pickup = await client.Pickup.Retrieve("pickup_...");

            pickup = await client.Pickup.Cancel(pickup.Id);

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
