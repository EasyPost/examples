<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$event = \EasyPost\Order::retrieve("evt_...");

echo $event;
