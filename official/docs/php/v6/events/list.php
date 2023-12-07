<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$events = $client->event->all([
    'page_size' => 5
]);

echo $events;
