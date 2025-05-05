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

            EasyPost.Parameters.Parcel.Create parameters = new()
            {
                Length = 20.2,
                Width = 10.9,
                Height = 5,
                Weight = 65.9
            };

            EasyPost.Models.API.Parcel parcel = await client.Parcel.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
        }
    }
}
