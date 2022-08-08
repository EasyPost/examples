using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Pickup pickup = await Pickup.Retrieve("pickup_...");

await pickup.Cancel();

Console.WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
