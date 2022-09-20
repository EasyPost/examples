<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$endshippers = \EasyPost\EndShipper::all(array(
    "page_size" => 5
));

echo $endshippers;
