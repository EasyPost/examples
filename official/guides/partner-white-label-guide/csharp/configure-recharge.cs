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

            EasyPost.Parameters.User.Update parameters = new()
            {
                RechargeThreshold = "50.00",
            };

            EasyPost.Models.API.User me = await client.User.RetrieveMe();

            me = await client.User.Update(me.Id!, parameters);
        }
    }
}
