<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$batches = Batch::all([
    'page_size' => 5,
]);

echo $batches;
