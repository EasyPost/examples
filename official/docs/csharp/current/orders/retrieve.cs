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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Order order = await client.Order.Retrieve("order_...");

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
