<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$tracker = \EasyPost\Tracker::retrieve("trk_...");

echo $tracker;
