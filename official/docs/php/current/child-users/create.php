<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$child = $client->user->create([
    'name' => 'Child Account Name'
]);

echo $child;
