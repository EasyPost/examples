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

            Shipment shipment = await Shipment.Create(new Dictionary<string, object>()
            {
                {
                    "to_address", new Dictionary<string, object>()
                    {
                        { "name", "Dr. Steve Brule" },
                        { "street1", "179 N Harbor Dr" },
                        { "city", "Redondo Beach" },
                        { "state", "CA" },
                        { "zip", "90277" },
                        { "country", "US" },
                        { "phone", "8573875756" },
                        { "email", "dr_steve_brule@gmail.com" }
                    }
                },
                {
                    "from_address", new Dictionary<string, object>()
                    {
                        { "company", "EasyPost" },
                        { "street1", "417 Montgomery Street" },
                        { "street2", "5th Floor" },
                        { "city", "San Francisco" },
                        { "state", "CA" },
                        { "zip", "94104" },
                        { "country", "US" },
                        { "phone", "4153334445" },
                        { "email", "support@easypost.com" }
                    }
                },
                {
                    "parcel", new Dictionary<string, object>()
                    {
                        { "length", 20.2 },
                        { "width", 10.9 },
                        { "height", 5 },
                        { "weight", 65.9 }
                    }
                },
                {
                    "customs_info", new Dictionary<string, object>()
                    {
                        { "id", "cstinfo_..." }
                    }
                },
                {
                    "tax_identifiers", new List<Dictionary<string, object>>()
                    {
                        new Dictionary<string, object>()
                        {
                            { "entity", "SENDER" },
                            { "tax_id", "GB123456789" },
                            { "tax_id_type", "EORI" },
                            { "issuing_country", "GB" }
                        }
                    }
                }
            });

            Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
        }
    }
}
