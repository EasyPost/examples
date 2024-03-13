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

            Parameters.Address.Create parameters = new()
            {
                Street1 = "417 Montgomery Street",
                Street2 = "FL 5",
                City = "San Francisco",
                State = "CA",
                Zip = "94104",
                Country = "US",
                Company = "EasyPost",
                Phone = "415-123-4567",
            };

            Address address = await client.Address.CreateAndVerify(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
