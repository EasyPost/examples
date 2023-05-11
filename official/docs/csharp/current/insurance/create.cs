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

            Address toAddress = await client.Address.Retrieve("adr_...");
            Address fromAddress = await client.Address.Retrieve("adr_...");

            Parameters.Insurance.Create parameters = new()
            {
                Amount = 100.00,
                Carrier = "USPS",
                TrackingCode = "9400110898825022579493",
                ToAddress = toAddress,
                FromAddress = fromAddress,
            };

            Insurance insurance = await client.Insurance.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
        }
    }
}
