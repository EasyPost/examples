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

            try
            {
                EasyPost.Parameters.Address.Create parameters = new()
                {
                    VerifyStrict = true
                };
                EasyPost.Models.API.Address address = await client.Address.Create(parameters);
            }
            catch (EasyPost.Exceptions.API.ApiError error)
            {
                Console.Write(error.Code); // ADDRESS.VERIFY.FAILURE
            }
        }
    }
}
