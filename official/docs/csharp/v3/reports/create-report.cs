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

            Report report = await Report.Create("payment_log", new Dictionary<string, object>()
            {
                { "start_date", "2022-10-01" },
                { "end_date", "2022-10-31" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
        }
    }
}
