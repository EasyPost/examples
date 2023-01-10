<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$user = $client->user->retrieve('user_...');

$client->$user->delete($user->id);
