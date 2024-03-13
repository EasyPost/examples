<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$scanForm = $client->scanForm->retrieve('sf_...');

echo $scanForm;
