<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$event = \EasyPost\Event::retrieve('evt_...');

echo $event;
