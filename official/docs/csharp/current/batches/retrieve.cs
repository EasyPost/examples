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

            Batch batch = await client.Batch.Retrieve("batch_...");

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
