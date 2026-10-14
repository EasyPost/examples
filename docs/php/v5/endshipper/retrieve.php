<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$endshipper = \EasyPost\EndShipper::retrieve('es_...');

echo $endshipper;
