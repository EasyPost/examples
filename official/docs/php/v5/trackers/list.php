<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$trackers = \EasyPost\Tracker::all([
    'page_size' => 5,
]);

echo $trackers;
