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

            address = await client.Address.Verify("adr_...");

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
