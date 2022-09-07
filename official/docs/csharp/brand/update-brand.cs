using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            EasyPost.ClientManager.SetCurrent(apiKey);

            User user = await User.RetrieveMe();

            await user.Update(new Dictionary<string, object>()
            {
                {
                    "background_color", "#FFFFFF"
                },
                {
                    "color", "#303F9F"
                },
                {
                    "logo", "data:image/png;base64,iVBORw0K..."
                },
                {
                    "logo_href", "https://easypost.com"
                },
                {
                    "ad", null
                },
                {
                    "ad_href", null
                },
                {
                    "theme", "theme1"
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
