using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Batch batch = await client.Batch.Retrieve("batch_...");

            Parameters.Batch.GenerateLabel parameters = new()
            {
                FileFormat = "PDF",
            }

            batch = await client.Batch.GenerateLabel(batch.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
