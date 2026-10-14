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

            ScanForm scanForm = await ScanForm.Retrieve("sf_...");

            Console.WriteLine(JsonConvert.SerializeObject(scanForm, Formatting.Indented));
        }
    }
}
