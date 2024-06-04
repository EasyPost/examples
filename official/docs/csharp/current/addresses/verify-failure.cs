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

            Parameters.Address.Create parameters = new()
            {
                Street1 = "000 unknown street",
                City = "Not A City",
                State = "ZZ",
                Zip = "00001",
                Country = "US",
                Email = "test@example.com",
                Phone = "5555555555",
            };

            Address address = await client.Address.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
