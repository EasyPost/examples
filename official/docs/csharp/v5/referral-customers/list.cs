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

            EasyPost.Parameters.ReferralCustomer.All parameters = new()
            {
                PageSize = 5
            };

            EasyPost.Models.API.ReferralCustomerCollection referralCustomerCollection = await client.ReferralCustomer.All(parameters);

            List<EasyPost.Models.API.ReferralCustomer> referralCustomers = referralCustomerCollection.ReferralCustomers;

            Console.WriteLine(JsonConvert.SerializeObject(referralCustomers, Formatting.Indented));
        }
    }
}
