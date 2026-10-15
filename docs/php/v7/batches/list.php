<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batches = $client->batch->all([
    'page_size' => 5,
]);

echo $batches;
