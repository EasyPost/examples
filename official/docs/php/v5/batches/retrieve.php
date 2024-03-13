<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$batch = \EasyPost\Batch::retrieve('batch_...');

echo $batch;
