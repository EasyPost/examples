using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples;

public class Examples
{
    [Fact]
    public async Task CreateShipmentWithTaxIdentifiers()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Shipment shipment = await Shipment.Create(new Dictionary<string, object>()
        {
            {
                "parcel", new Dictionary<string, object>()
                {
                    {
                        "length", 20.2
                    },
                    {
                        "width", 10.9
                    },
                    {
                        "height", 5
                    },
                    {
                        "weight", 65.9
                    }
                }
            },
            {
                "from_address", new Dictionary<string, object>()
                {
                    {
                        "company", "EasyPost"
                    },
                    {
                        "street1", "417 Montgomery Street"
                    },
                    {
                        "street2", "5th Floor"
                    },
                    {
                        "city", "San Francisco"
                    },
                    {
                        "state", "CA"
                    },
                    {
                        "zip", "94104"
                    },
                    {
                        "country", "US"
                    },
                    {
                        "phone", "4153334445"
                    },
                    {
                        "email", "support@easypost.com"
                    }
                }
            },
            {
                "to_address", new Dictionary<string, object>()
                {
                    {
                        "name", "Dr. Steve Brule"
                    },
                    {
                        "street1", "179 N Harbor Dr"
                    },
                    {
                        "city", "Redondo Beach"
                    },
                    {
                        "state", "CA"
                    },
                    {
                        "country", "US"
                    },
                    {
                        "phone", "8573875756"
                    },
                    {
                        "email", "dr_steve_brule@gmail.com"
                    },
                    {
                        "zip", "90277"
                    }
                }
            },
            {
                "customs_info", new Dictionary<string, object>()
                {
                    {
                        "id", "cstinfo_..."
                    }
                }
            },
            {
                "tax_identifiers", new List<Dictionary<string, object>>()
                {
                    new Dictionary<string, object>()
                    {
                        {
                            "entity", "SENDER"
                        },
                        {
                            "tax_id", "GB123456789"
                        },
                        {
                            "tax_id_type", "EORI"
                        },
                        {
                            "issuing_country", "GB"
                        }
                    }
                }
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
    }
}
