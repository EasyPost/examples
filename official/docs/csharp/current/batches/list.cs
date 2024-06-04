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

            Parameters.Batch.All parameters = new()
            {
                PageSize = 5
            };

            BatchCollection batchCollection = await client.Batch.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(batchCollection, Formatting.Indented));
        }
    }
}
