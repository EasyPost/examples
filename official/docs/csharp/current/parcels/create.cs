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

            Parameters.Parcel.Create parameters = new()
            {
                Length = 20.2,
                Width = 10.9,
                Height = 5,
                Weight = 65.9
            };

            Parcel parcel = await client.Parcel.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
        }
    }
}
