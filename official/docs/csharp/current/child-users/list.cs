using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Parameters.Users.AllChildren parameters = new()
            {
                PageSize = 5
            };

            ChildUserCollection childUserCollection = await client.User.AllChildren(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(childUserCollection, Formatting.Indented));
        }
    }
}
