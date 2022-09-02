<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$events = \EasyPost\Event::all([
    'page_size' => 5
]);

echo $events;
