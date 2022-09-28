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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            List<CarrierAccount> carrierAccounts = await client.CarrierAccount.All();

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccounts, Formatting.Indented));
        }
    }
}
