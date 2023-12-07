<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$parcel = $client->parcel->retrieve('prcl_...');

echo $parcel;
