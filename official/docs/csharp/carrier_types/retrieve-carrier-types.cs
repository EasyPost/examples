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

            List<CarrierType> carrierTypes = await CarrierType.All();

            Console.WriteLine(JsonConvert.SerializeObject(carrierTypes, Formatting.Indented));
        }
    }
}
