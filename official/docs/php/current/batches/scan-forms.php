<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batch = $client->batch->createScanForm('batch_...');

echo $batch;
