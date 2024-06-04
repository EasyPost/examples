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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            CarrierAccount carrierAccount = await client.CarrierAccount.Retrieve("ca_...");

            await client.CarrierAccount.Delete(carrierAccount.Id);
        }
    }
