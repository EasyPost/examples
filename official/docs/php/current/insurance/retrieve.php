<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$insurance = $client->insurance->retrieve('ins_...');

echo $insurance;
