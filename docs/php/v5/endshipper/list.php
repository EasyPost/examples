<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$endshippers = \EasyPost\EndShipper::all([
    'page_size' => 5
]);

echo $endshippers;
