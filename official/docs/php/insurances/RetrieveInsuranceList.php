<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$insurances = \EasyPost\Insurance::all([
    'page_size' => 2,
    'start_datetime' => '2016-01-02T08:50:00Z'
]);

echo $insurances;
