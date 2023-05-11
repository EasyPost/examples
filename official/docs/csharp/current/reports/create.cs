using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Report report = await client.Report.Create("payment_log", new Dictionary<string, object>()
            {
                { "start_date", "2022-10-01" },
                { "end_date", "2022-10-31" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
        }
    }
}
