using System;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            ApiKey apiKey = await client.ApiKey.Create("test");

            Console.WriteLine(JsonConvert.SerializeObject(apiKey, Formatting.Indented));
        }
    }
}
