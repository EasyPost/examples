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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.Users.AllChildren parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.ChildUserCollection childUserCollection = await client.User.AllChildren(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(childUserCollection, Formatting.Indented));
        }
    }
}
