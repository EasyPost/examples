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

            EasyPost.ClientManager.SetCurrent(apiKey);

            CustomsItem customsItem = await CustomsItem.Create(new Dictionary<string, object>()
            {
                { "description", "T-shirt" },
                { "quantity", 1 },
                { "weight", 5 },
                { "value", 10 },
                { "hs_tariff_number", "123456" },
                { "origin_country", "US" },
            });

            Console.WriteLine(JsonConvert.SerializeObject(customsItem, Formatting.Indented));
        }
    }
}
