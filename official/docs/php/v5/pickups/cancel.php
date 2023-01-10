<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$pickup = \EasyPost\Pickup::retrieve('pickup_...');

$pickup->cancel();

echo $pickup;
