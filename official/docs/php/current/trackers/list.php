<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$trackers = \EasyPost\Tracker::all([
    'page_size' => 5,
]);

echo $trackers;
