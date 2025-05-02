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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.ReferralCustomer.Create parameters = new()
            {
                Name = "test user",
                Email = "email@example.com",
                Phone = "8888888888"
            };

            EasyPost.Models.API.ReferralCustomer referralUser = await client.ReferralCustomer.CreateReferral(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(referralUser, Formatting.Indented));
        }
    }
}
