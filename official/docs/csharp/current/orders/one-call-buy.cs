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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            Parameters.Order.Create parameters = new()
            {
                ToAddress = new Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                FromAddress = new Parameters.Address.Create
                {
                    Company = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "Floor 5",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                Shipments = new List<IShipmentParameter>
                {
                    new Parameters.Shipment.Create()
                    {
                        Parcel = new Parameters.Parcel.Create
                        {
                            Weight = 10.2
                        }
                    },
                    new Parameters.Shipment.Create()
                    {
                        Parcel = new Parameters.Parcel.Create
                        {
                            PredefinedPackage = "FedExBox",
                            Weight = 17.5
                        }
                    }
                },
                Service = "NextDayAir",
                CarrierAccounts = new List<CarrierAccount>
                {
                    new CarrierAccount
                    {
                        Id = "ca_..."
                    }
                }
            };

            Order order = await client.Order.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
