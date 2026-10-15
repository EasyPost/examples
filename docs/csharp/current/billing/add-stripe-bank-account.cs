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

            EasyPost.Models.API.PaymentMethod paymentMethod = await Client.ReferralCustomer.AddBankAccountFromStripe(
                "REFERRAL_USER_API_KEY",
                "fca_...",
                new Dictionary<string, object>
                {
                    { "ip_address", "127.0.0.1" },
                    { "user_agent", "Mozilla/5.0" },
                    { "accepted_at", 1722510730 }
                },
                EasyPost.Models.API.PaymentMethod.Priority.Primary
            );

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
        }
    }
}
