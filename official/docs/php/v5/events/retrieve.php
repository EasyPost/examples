<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$event = \EasyPost\Event::retrieve('evt_...');

echo $event;
