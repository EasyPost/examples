<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$tracker = $client->tracker->retrieve('trk_...');

echo $tracker;
