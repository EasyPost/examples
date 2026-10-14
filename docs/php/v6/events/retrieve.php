<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$event = $client->event->retrieve('evt_...');

echo $event;
