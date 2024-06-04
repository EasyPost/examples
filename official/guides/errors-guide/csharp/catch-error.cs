using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            try {
                Parameters.Address.Create parameters = new()
                {
                    VerifyStrict = true
                };
                Address address = await client.Address.Create(parameters);
            } catch (EasyPost.Exceptions.API.ApiError error) {
                Console.Write(error.Code); // ADDRESS.VERIFY.FAILURE
            }
        }
    }
}
