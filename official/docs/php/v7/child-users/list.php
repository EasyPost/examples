<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$childUsers = $client->user->allChildren([
    'page_size' => 5
]);

echo $childUsers;
