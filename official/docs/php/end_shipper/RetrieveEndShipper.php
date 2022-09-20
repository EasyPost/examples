<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$endshipper = \EasyPost\EndShipper::retrieve("es_...");

echo $endshipper;
