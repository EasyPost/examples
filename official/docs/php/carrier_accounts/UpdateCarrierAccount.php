<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrierAccount->credentials["pickup_id"] = "abc123";

$carrierAccount->save();

echo $carrierAccount;
