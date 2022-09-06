using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ScanFormCollection scanFormCollection = await ScanForm.All(new Dictionary<string, object>(){
  { "page_size", 5 }
});

Console.WriteLine(JsonConvert.SerializeObject(scanFormCollection, Formatting.Indented));
