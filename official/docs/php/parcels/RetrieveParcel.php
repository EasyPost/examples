<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$parcel = \EasyPost\Parcel::retrieve('prcl_...');

echo $parcel;
