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

            Parameters.Address.Create parameters = new()
            {
                Street1 = "417 MONTGOMERY ST",
                Street2 = "FLOOR 5",
                City = "SAN FRANCISCO",
                State = "CA",
                Zip = "94104",
                Country = "US",
                Company = "EasyPost",
                Phone = "415-123-4567",
                VerifyStrict = true
            };

            Address address = await client.Address.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
