using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

BatchCollection batchCollection = await Batch.All(new Dictionary<string, object>
{
    {
        "page_size", 5
    }
});

List<Batch> batches = batchCollection.batches;

Console.WriteLine(JsonConvert.SerializeObject(batches, Formatting.Indented));
