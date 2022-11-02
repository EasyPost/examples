<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$insurances = \EasyPost\Insurance::all([
    'page_size' => 5,
]);

echo $insurances;
