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

            EasyPost.Parameters.Claim.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.ClaimCollection claimCollection = await client.Claim.All(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(claimCollection, Formatting.Indented));
        }
    }
}
