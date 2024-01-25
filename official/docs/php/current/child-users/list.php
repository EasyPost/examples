<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$childUsers = $client->user->allChildren([
    'page_size' => 5
]);

echo $childUsers;
