<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->create_scan_form();

echo $batch;
