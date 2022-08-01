using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

listParams = new Dictionary<string, object>() { "page_size", 5 };

EventCollection events = await Event.All(listParams);

Console.WriteLine(JsonConvert.SerializeObject(events, Formatting.Indented));
