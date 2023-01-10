<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$rate = \EasyPost\Rate::retrieve('rate...');

echo $rate;
