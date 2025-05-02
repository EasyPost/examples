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

            EasyPost.Parameters.EndShipper.Create parameters = new()
            {
                Name = "FOO BAR",
                Company = "BAZ",
                Street1 = "164 TOWNSEND STREET UNIT 1",
                Street2 = "UNIT 1",
                City = "SAN FRANCISCO",
                State = "CA",
                Zip = "94107",
                Country = "US",
                Phone = "555-555-5555",
                Email = "FOO@EXAMPLE.COM",
            };

            EasyPost.Models.API.EndShipper endShipper = await client.EndShipper.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(endShipper, Formatting.Indented));
        }
    }
}
