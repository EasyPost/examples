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

            EasyPost.Parameters.CustomerPortal.CreateAccountLink parameters = new()
            {
                SessionType = "account_management",
                UserId = "user_...",
                RefreshUrl = "https://example.com/refresh",
                ReturnUrl = "https://example.com/return",
                Metadata = new System.Collections.Generic.Dictionary<string, object>
                {
                    { "target", "wallet" }
                }
            };

            EasyPost.Models.API.CustomerPortal.AccountLink accountLink = await client.CustomerPortal.CreateAccountLink(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(accountLink, Formatting.Indented));
        }
    }
}
