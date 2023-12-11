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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            EndShipper endShipper = await client.EndShipper.Retrieve("es_...");

            // Updating an EndShipper requires all the original data to be sent back + the updated data
            Parameters.EndShipper.Update parameters = new()
            {
                Name = "NEW NAME",
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

            endShipper = await client.EndShipper.Update(endShipper.Id, parameters);

            Console.WriteLine(JsonConvert.SerializeObject(endShipper, Formatting.Indented));
        }
    }
}
