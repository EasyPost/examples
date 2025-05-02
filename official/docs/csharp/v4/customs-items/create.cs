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

            EasyPost.Models.API.CustomsItem customsItem = await client.CustomsItem.Create(new Dictionary<string, object>()
            {
                { "description", "T-shirt" },
                { "quantity", 1 },
                { "weight", 5 },
                { "value", 10 },
                { "hs_tariff_number", "123456" },
                { "origin_country", "US" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(customsItem, Formatting.Indented));
        }
    }
}
