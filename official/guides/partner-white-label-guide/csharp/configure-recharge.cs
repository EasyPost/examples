using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Parameters.User.Update parameters = new()
            {
                RechargeThreshold = "50.00",
            };

            User me = await client.User.RetrieveMe();

            me = await client.User.Update(me.Id!, parameters);
        }
    }
}
