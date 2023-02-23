<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->retrieve('batch_...');

$batchWithLabel = $client->batch->label(
    $batch->id,
    ['file_format' => 'PDF']
);

echo $batchWithLabel;
