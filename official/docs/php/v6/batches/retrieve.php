<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->retrieve('batch_...');

echo $batch;
