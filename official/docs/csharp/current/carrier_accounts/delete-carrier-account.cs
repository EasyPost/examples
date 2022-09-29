using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = EasyPost.Client(apiKey);

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            bool success = await carrierAccount.Delete();

            Console.WriteLine(success.ToString());
        }
    }
