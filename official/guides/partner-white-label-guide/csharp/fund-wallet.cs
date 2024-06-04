using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            await client.Billing.FundWallet("20.00", PaymentMethod.Priority.Primary);
        }
    }
}
