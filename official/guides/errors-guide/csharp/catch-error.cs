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

            // When the `errors` key is returned as an array of FieldError objects
            try
            {
                // Simulate a request with missing parameters
                await client.Shipment.Create(new Dictionary<string, object>());
            }
            catch (ApiError error)
            {
                FieldError fieldError = (FieldError)error.Errors.First();
                Console.Write(fieldError.Message);
            }

            // When the `errors` key is returned as an array of strings
            try
            {
                var claimParameters = new EasyPost.Parameters.Claims.Create
                {
                    TrackingCode = "123" // Simulate a request with an invalid tracking code
                }
                await Client.Claim.Create(claimParameters);
            }
            catch (ApiError error)
            {
                Console.Write(error.Errors.First());
            }
        }
    }
}
