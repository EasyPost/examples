<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$order = \EasyPost\Order::retrieve('order_...');

echo $order;
