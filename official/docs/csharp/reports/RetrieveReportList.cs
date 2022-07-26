using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ReportCollection reportCollection = await Report.All("payment_log", new DictionaryM<string, object>(){
    { "page_size", 4 },
    { "start_date", "2016-01-02" }
});

Console.Write(report);
