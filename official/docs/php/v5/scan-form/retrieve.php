<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$scanForm = \EasyPost\ScanForm::retrieve('sf_...');

echo $scanForm;
