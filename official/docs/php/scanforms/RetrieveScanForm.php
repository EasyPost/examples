<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$scanForm = \EasyPost\ScanForm::retrieve('sf_...');

echo $scanForm;
