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

            EasyPost.Parameters.Embeddable.CreateSession parameters = new()
            {
                OriginHost = "https://example.com",
                UserId = "user_..."
            };

            EasyPost.Models.API.EmbeddablesSession session = await client.Embeddable.CreateSession(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(session, Formatting.Indented));
        }
    }
}
