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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            EndShipper retrievedEndShipper = await EndShipper.Retrieve("es_...");

            Console.WriteLine(JsonConvert.SerializeObject(retrievedEndShipper, Formatting.Indented));
        }
    }
}
