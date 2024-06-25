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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Parameters.Order.Buy parameters = new("FedEx", "FEDEX_GROUND");

            order = await client.Order.Buy("order_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
