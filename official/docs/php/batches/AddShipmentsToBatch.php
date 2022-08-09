<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$params = array(
    'shipments' => array(
      array(
        'id' => 'shp_...'
      ),
      array(
        'id' => 'shp_...'
      )
    )
  );
  
$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->add_shipments($params);

echo $batch;
