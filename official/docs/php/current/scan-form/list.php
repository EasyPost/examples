<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$scanForms = $client->scanForm->all([
    'page_size' => 5
]);

echo $scanForms;
