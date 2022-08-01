using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Event events = await Event.Retrieve("event_...");

Console.WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
