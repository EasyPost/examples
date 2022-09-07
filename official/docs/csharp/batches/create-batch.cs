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

            Batch batch = await Batch.Create(new Dictionary<string, object>()
            {
                {
                    "shipments", new Dictionary<string, object>()
                    {
                        {
                            "id", "shp_..."
                        },
                        {
                            "id", "shp_..."
                        }
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(batch, Formatting.Indented));
        }
    }
}
