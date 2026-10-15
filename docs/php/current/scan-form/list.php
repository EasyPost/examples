<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$scanForms = $client->scanForm->all([
    'page_size' => 5
]);

echo $scanForms;
