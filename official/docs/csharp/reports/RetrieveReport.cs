using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Report report = await Report.Retrieve("<REPORT_ID>");

Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
