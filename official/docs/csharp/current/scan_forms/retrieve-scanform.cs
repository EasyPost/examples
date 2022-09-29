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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            ScanForm scanForm = await client.ScanForm.Retrieve("sf_...");

            Console.WriteLine(JsonConvert.SerializeObject(scanForm, Formatting.Indented));
        }
    }
}
