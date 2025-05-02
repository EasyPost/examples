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

            EasyPost.Models.API.Order order = await client.Order.Retrieve("order_...");

            EasyPost.Parameters.Order.Buy parameters = new("FedEx", "FEDEX_GROUND");

            order = await client.Order.Buy(order.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
