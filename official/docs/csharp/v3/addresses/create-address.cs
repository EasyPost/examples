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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            Address address = await Address.Create(
                new Dictionary<string, object>
                {
                    { "street1", "417 MONTGOMERY ST" },
                    { "street2", "FLOOR 5" },
                    { "city", "SAN FRANCISCO" },
                    { "state", "CA" },
                    { "zip", "94104" },
                    { "country", "US" },
                    { "company", "EasyPost" },
                    { "phone", "415-123-4567" },
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
        }
    }
}
