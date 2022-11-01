using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Address toAddress = await Address.Create(toAddress);
            Address fromAddress = await Address.Create(fromAddress);
            Parcel parcel = await Parcel.Create(parcel);
            CustomsInfo customs = await CustomsInfo.Create(customsInfo);

            Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
                { "to_address", toAddress },
                { "from_address", fromAddress },
                { "parcel", parcel },
                { "customs_info", customs }
            }, withCarbonOffset: true);

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
