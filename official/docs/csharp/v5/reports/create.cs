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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            EasyPost.Parameters.Report.Create parameters = new()
            {
                Type = "payment_log",
                StartDate = "2022-10-01",
                EndDate = "2022-10-31"
            };

            EasyPost.Models.API.Report report = await client.Report.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
        }
    }
}
