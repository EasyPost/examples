<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$parcel = \EasyPost\Parcel::retrieve('prcl_...');

echo $parcel;
