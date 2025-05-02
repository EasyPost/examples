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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.EndShipper.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.EndShipperCollection endShipperCollection = await client.EndShipper.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(endShipperCollection, Formatting.Indented));
        }
    }
}
