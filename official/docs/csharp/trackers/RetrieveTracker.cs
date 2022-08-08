using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Tracker tracker = await Tracker.Retrieve("trk_...");

Console.WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
