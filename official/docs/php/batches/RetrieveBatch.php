<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$batch = Batch::retrieve("batch_...");

echo $batch;
