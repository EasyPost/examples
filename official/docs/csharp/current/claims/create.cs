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

            Parameters.Claim.Create parameters = new()
            {
                Amount = 100.00,
                Type = ClaimType.Damage
                EmailEvidenceAttachments = new string[]
                {
                    "REPLACE_WITH_BASE64_STRING"
                },
                InvoiceAttachments = new string[]
                {
                    "REPLACE_WITH_BASE64_STRING"
                },
                SupportingDocumentationAttachments = new string[]
                {
                    "REPLACE_WITH_BASE64_STRING"
                },
                Description = "Test description",
                ContactEmail = "test@example.com",
                TrackingCode = "YOUR_TRACKING_CODE",
            };

            Claim claim = await client.Claim.Create(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(claim, Formatting.Indented));
        }
    }
}
