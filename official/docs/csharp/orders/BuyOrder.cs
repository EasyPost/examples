using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Order order = await Order.Retrieve("order_...");

await order.Buy("FedEx", "FEDEX_GROUND");

Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
