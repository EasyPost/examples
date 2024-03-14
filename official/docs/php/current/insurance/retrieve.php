<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$insurance = $client->insurance->retrieve('ins_...');

echo $insurance;
