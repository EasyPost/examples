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

            EasyPost.Parameters.Report.All parameters = new()
            {
                Type = "payment_log",
                PageSize = 5,
                StartDatetime = "2022-10-01"
            };

            EasyPost.Models.API.ReportCollection reportCollection = await client.Report.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(reportCollection, Formatting.Indented));
        }
    }
}
