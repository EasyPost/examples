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

            EasyPost.Parameters.Refund.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.RefundCollection refundCollection = await client.Refund.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refundCollection, Formatting.Indented));
        }
    }
}
