<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$insurance = $client->insurance->refund('ins_...');

echo $insurance;
