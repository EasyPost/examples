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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            pickup = await client.Pickup.Cancel("pickup_...");

            Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
        }
    }
}
