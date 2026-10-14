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

            EasyPost.Models.API.Batch batch = await client.Batch.Retrieve("batch_...");

            EasyPost.Parameters.Batch.GenerateScanForm parameters = new()
            {
                FileFormat = "ZPL",
            };

            batch = await client.Batch.GenerateScanForm(batch.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
