<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$scanForm = $client->scanForm->retrieve('sf_...');

echo $scanForm;
