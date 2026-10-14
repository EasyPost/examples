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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            ReportCollection reportCollection = await Report.All("payment_log", new Dictionary<string, object>()
            {
                { "page_size", 5 },
                { "start_date", "2022-10-01" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(reportCollection, Formatting.Indented));
        }
    }
}
