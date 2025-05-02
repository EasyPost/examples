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

            EasyPost.Parameters.CustomsInfo.Create parameters = new()
            {
                CustomsCertify = true,
                CustomsSigner = "Steve Brule",
                ContentsType = "merchandise",
                ContentsExplanation = "",
                RestrictionType = "none",
                EelPfc = "NOEEI 30.37(a)",
                CustomsItems = new List<EasyPost.Parameters.CustomsItem.Create>()
                {
                    new()
                    {
                        Description = "T-shirt",
                        Quantity = 1,
                        Weight = 5,
                        Value = 10,
                        HsTariffNumber = "123456",
                        OriginCountry = "US"
                    }
                }
            };

            EasyPost.Models.API.CustomsInfo customsInfo = await client.CustomsInfo.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(customsInfo, Formatting.Indented));
        }
    }
}
