<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$parcel = $client->parcel->retrieve('prcl_...');

echo $parcel;
