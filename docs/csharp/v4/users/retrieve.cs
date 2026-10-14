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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            // Retrieve the authenticated user
            EasyPost.Models.API.User user = await client.User.RetrieveMe();

            // Retrieve a child user
            User user = await client.User.Retrieve("user_...");

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
