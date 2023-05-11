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
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            User user = await client.User.RetrieveMe();

            await user.UpdateBrand(new Dictionary<string, object>()
            {
                { "background_color", "#FFFFFF" },
                { "color", "#303F9F" },
                { "logo", "data:image/png;base64,iVBORw0K..." },
                { "logo_href", "https://easypost.com" },
                { "ad", null },
                { "ad_href", null },
                { "theme", "theme1" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
