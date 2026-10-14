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

            EndShipperCollection endShipperCollection = await EndShipper.All(new Dictionary<string, object>
            {
                {
                    "page_size", 5
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(endShipperCollection, Formatting.Indented));
        }
    }
}
