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

            Dictionary<string, object> listParams = new Dictionary<string, object>()
            {
                { "page_size", 5 }
            };

            ShipmentCollection shipmentCollection = await Shipment.All(listParams);

            Console.WriteLine(JsonConvert.SerializeObject(shipmentCollection, Formatting.Indented));
        }
    }
}
