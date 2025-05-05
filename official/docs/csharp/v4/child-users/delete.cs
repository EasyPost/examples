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

            EasyPost.Models.API.User user = await client.User.Retrieve("user_...");

            bool success = await user.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
