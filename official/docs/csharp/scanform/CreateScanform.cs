using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ScanForm scanForm = await ScanForm.Create(new List<Dictionary<string, object>>(){
    {"id", "shp_..."},
    {"id", "shp_..."}
});

Console.Write(scanForm);
