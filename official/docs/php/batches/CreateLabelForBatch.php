<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->label(['file_format' => 'PDF']);

echo $batch;
