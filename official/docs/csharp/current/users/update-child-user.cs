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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            User childUser = await client.User.Retrieve("user_..");

            await childUser.Update(new Dictionary<string, object>()
            {
                { "name", "Test Child" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(childUser, Formatting.Indented));
        }
    }
}
