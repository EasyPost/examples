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

            User user = await client.User.RetrieveMe();

            EasyPost.Parameters.User.Update parameters = new()
            {
                RechargeThreshold = "50.00"
            };

            user = await client.User.Update(user.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
