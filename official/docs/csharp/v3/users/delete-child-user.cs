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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            User user = await User.Retrieve("user_...");

            bool success = await user.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
