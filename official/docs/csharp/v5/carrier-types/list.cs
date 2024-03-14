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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            List<CarrierType> carrierTypes = await client.CarrierType.All();

            Console.WriteLine(JsonConvert.SerializeObject(carrierTypes, Formatting.Indented));
        }
    }
}
