<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batchWithLabel = $client->batch->label(
    'batch_...',
    ['file_format' => 'PDF']
);

echo $batchWithLabel;
