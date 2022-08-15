<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$insurance = \EasyPost\Insurance::retrieve("ins_...");

echo $insurance;
