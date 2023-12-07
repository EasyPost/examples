<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$event = $client->event->retrieve('evt_...');

echo $event;
