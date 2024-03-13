<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batch = $client->batch->retrieve('batch_...');

$boughtBatch = $client->batch->buy($batch->id);

echo $boughtBatch;
