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

            BatchCollection batchCollection = await Batch.All(new Dictionary<string, object>
            {
                { "page_size", 5 }
            });

            Console.WriteLine(JsonConvert.SerializeObject(batchCollection, Formatting.Indented));
        }
    }
}
