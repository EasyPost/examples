using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> listParams = new Dictionary<string, object>() {
  { "page_size", 5 }
};

ScanFormCollection scanFormCollection =  await ScanForm.All(listParams);
ScanFormCollection nextScanFormCollection = await scanFormCollection.Next();
