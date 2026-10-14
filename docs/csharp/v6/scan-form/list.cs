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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.ScanForm.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.ScanFormCollection scanFormCollection = await client.ScanForm.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(scanFormCollection, Formatting.Indented));
        }
    }
}
