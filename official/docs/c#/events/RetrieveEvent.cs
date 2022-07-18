using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Event event = await Event.Retrieve("evt_...");
