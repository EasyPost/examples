<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$rate = \EasyPost\Rate::retrieve('rate...');

echo $rate;
