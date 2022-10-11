using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

            await Partner.UpdateReferralEmail("user_...", "new_email@example.com");
        }
    }
}

