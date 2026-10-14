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

            Order order = await Order.Retrieve("order_...");

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
