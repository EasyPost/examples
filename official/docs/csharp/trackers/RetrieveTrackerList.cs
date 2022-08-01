using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> listParams = new Dictionary<string, object>() {
  { "page_size", 5 }
};

TrackerCollection trackerCollection = await Tracker.All(listParams);

Console.WriteLine(JsonConvert.SerializeObject(trackerCollection, Formatting.Indented));
