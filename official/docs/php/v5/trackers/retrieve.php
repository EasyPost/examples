<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$tracker = \EasyPost\Tracker::retrieve('trk_...');

echo $tracker;
