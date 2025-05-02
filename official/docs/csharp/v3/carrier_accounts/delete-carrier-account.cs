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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

            bool success = await carrierAccount.Delete();

            Console.WriteLine(success.ToString());
        }
    }
}
