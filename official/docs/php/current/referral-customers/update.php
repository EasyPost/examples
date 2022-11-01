<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

Referral::update_email('new_email@example.com', 'user_...');
