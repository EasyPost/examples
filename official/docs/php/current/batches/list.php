<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$batches = \EasyPost\Batch::all([
    'page_size' => 5,
]);

echo $batches;
