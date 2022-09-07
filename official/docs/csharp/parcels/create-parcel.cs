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

            Parcel parcel = await Parcel.Create(new Dictionary<string, object>()
            {
                {
                    "length", 20.2
                },
                {
                    "width", 10.9
                },
                {
                    "height", 5
                },
                {
                    "weight", 65.9
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
        }
    }
}
