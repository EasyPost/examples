using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Insurance insurance = await Insurance.Retrieve("ins_...");

Console.WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
