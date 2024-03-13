using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Insurance insurance = await client.Insurance.Retrieve("ins_...");

            Console.WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
        }
    }
}
