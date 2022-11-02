<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$insurance = \EasyPost\Insurance::retrieve('ins_...');

echo $insurance;
