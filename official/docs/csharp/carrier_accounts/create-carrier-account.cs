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
    public async Task CreateCarrierAccount()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        CarrierAccount carrierAccount = await CarrierAccount.Create(new Dictionary<string, object>()
        {
            {
                "type", "UpsAccount"
            },
            {
                "description", "NY Location UPS Account"
            },
            {
                "reference", "my-reference"
            },
            {
                "credentials", new Dictionary<string, object>
                {
                    {
                        "account_number", "A1A1A1"
                    },
                    {
                        "user_id", "USERID"
                    },
                    {
                        "password", "PASSWORD"
                    },
                    {
                        "access_license_number", "ALN"
                    }
                }
            },
            {
                "test_credentials", new Dictionary<string, object>
                {
                    {
                        "account_number", "A1A1A1"
                    },
                    {
                        "user_id", "USERID"
                    },
                    {
                        "password", "PASSWORD"
                    },
                    {
                        "access_license_number", "ALN"
                    }
                }
            },
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
    }
}
