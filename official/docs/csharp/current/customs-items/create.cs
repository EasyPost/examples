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

            Parameters.CustomsItems.Create parameters = new()
            {
                Description = "T-shirt",
                Quantity = 1,
                Weight = 5,
                Value = 10,
                HsTariffNumber = "123456",
                OriginCountry = "US"
            };

            CustomsItem customsItem = await client.CustomsItem.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(customsItem, Formatting.Indented));
        }
    }
}
