<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$batch = \EasyPost\Batch::create(array(
    'shipments' => array(array(
      'id' => "shp_...",
      'id' => "shp_..."
    ))
  ));

echo $batch;
