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

            Parameters.CustomsInfo.Create parameters = new()
            {
                CustomsCertify = true,
                CustomsSigner = "Steve Brule",
                ContentsType = "merchandise",
                ContentsExplanation = "",
                RestrictionType = "none",
                EelPfc = "NOEEI 30.37(a)",
                CustomsItems = new List<Parameters.CustomsItem.Create>()
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

            CustomsInfo customsInfo = await client.CustomsInfo.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(customsInfo, Formatting.Indented));
        }
    }
}
