using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");



Report report = await Report.Create("payment_log", new Dictionary<string, object>(){
    { "start_date", "2016-10-01" },
    { "end_date", "2016-10-31" }
});

Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
