<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$order = $client->order->retrieve('order_...');

echo $order;
