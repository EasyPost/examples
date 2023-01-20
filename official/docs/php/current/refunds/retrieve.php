<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$refund = $client->refund->retrieve('rfnd_...');

echo $refund;
