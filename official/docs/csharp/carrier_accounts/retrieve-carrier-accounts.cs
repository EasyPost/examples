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

            List<CarrierAccount> carrierAccounts = await CarrierAccount.All();

            Console.WriteLine(JsonConvert.SerializeObject(carrierAccounts, Formatting.Indented));
        }
    }
}
