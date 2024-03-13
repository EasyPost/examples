<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$endshippers = $client->endShipper->all([
    'page_size' => 5
]);

echo $endshippers;
