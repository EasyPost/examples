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

            EasyPost.Models.API.CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            bool success = await carrierAccount.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
