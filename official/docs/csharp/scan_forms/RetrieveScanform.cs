using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ScanForm scanForm = await ScanForm.Retrieve("sf_...");

Console.WriteLine(JsonConvert.SerializeObject(scanForm, Formatting.Indented));
