<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

// Get first page of results
$shipments = $client->shipment->all([
    'page_size' => 5,
]);

// Provide the previous results page to move onto the next page
$nextPage = $client->shipments->getNextPage($shipments);

echo $nextPage;
