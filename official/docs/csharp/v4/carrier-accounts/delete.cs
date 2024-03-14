using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            bool success = await carrierAccount.Delete();

            Console.WriteLine(success.ToString());
        }
    }
