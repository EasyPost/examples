using System;
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

            var response = await client.Beta.ReferralCustomer.RetrieveEasypostStripeApiKey();

            Console.WriteLine(JsonConvert.SerializeObject(response, Formatting.Indented));
        }
    }
}
