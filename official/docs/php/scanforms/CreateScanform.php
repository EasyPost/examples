<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$scan_form = \EasyPost\ScanForm::create(array(
    "shipments" => array(
        array(
            "id" => "shp_..."
        ),
        array(
            "id" => "shp_..."
        )
    )
));

echo $scan_form;
