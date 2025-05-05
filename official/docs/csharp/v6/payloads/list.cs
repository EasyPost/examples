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

            List<EasyPost.Models.API.Payload> payloads = await client.Event.RetrieveAllPayloads("evt_...");

            Console.WriteLine(JsonConvert.SerializeObject(payloads, Formatting.Indented));
        }
    }
}
