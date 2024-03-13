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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Batch batch = await client.Batch.Create(new Dictionary<string, object>()
            {
                {
                    "shipments", new Dictionary<string, object>()
                    {
                        { "id", "shp_..." },
                        { "id", "shp_..." }
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
