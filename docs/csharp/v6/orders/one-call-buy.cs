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

            EasyPost.Parameters.Order.Create parameters = new()
            {
                ToAddress = new EasyPost.Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Company = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "Floor 5",
                    City = "San Francisco",
                    State = "CA",
                    Country = "US",
                    Zip = "94104"
                },
                Shipments = new List<EasyPost.Parameters.IShipmentParameter>
                {
                    new EasyPost.Parameters.Shipment.Create()
                    {
                        Parcel = new EasyPost.Parameters.Parcel.Create
                        {
                            Weight = 10.2
                        }
                    },
                    new EasyPost.Parameters.Shipment.Create()
                    {
                        Parcel = new EasyPost.Parameters.Parcel.Create
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

            EasyPost.Models.API.Order order = await client.Order.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
