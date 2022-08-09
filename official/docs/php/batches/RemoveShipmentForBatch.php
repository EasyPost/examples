<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$params = array(
    'shipments' => array(
      array(
        'id' => 'shp_...',
      )
    )
  );
  
$batch = \EasyPost\Batch::retrieve('batch_...');
$batch->remove_shipments($params);

echo $batch;
