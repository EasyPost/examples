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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            User user = await User.RetrieveMe();

            await user.Update(new Dictionary<string, object>()
            {
                { "recharge_threshold", 50.00 }
            });

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
