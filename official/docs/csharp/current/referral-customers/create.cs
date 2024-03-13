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

            Parameters.ReferralCustomer.Create parameters = new()
            {
                Name = "test user",
                Email = "email@example.com",
                Phone = "8888888888"
            };

            ReferralCustomer referralUser = await client.ReferralCustomer.CreateReferral(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(referralUser, Formatting.Indented));
        }
    }
}
