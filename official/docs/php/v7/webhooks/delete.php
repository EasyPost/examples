<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$client->webhook->delete('hook_...');
