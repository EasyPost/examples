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

            User childUser = await User.Retrieve("user_..");

            await childUser.Update(new Dictionary<string, object>()
            {
                {
                    "name", "Test Child"
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(childUser, Formatting.Indented));
        }
    }
}
