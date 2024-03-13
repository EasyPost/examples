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

            Parameters.ReferralCustomer.All parameters = new()
            {
                PageSize = 5
            };

            ReferralCustomerCollection referralCustomerCollection = await client.ReferralCustomer.All(parameters);

            List<ReferralCustomer> referralCustomers = referralCustomerCollection.ReferralCustomers;

            Console.WriteLine(JsonConvert.SerializeObject(referralCustomers, Formatting.Indented));
        }
    }
}
