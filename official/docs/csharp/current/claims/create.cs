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
                EmailEvidenceAttachments = new string[]
                {
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="
                },
                InvoiceAttachments = new string[]
                {
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="
                },
                SupportingDocumentationAttachments = new string[]
                {
                    "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAAeUlEQVR42mP8//8/AwAI/AL+4Q7AIAAAAABJRU5ErkJggg=="
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
