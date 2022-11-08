require_once("path/to/lib/easypost.php");
\EasyPost\EasyPost::setApiKey("<YOUR_TEST/PRODUCTION_API_KEY>");

$fromAddress = \EasyPost\Address::create(array(
  'company' => 'EasyPost',
  'street1' => '417 Montgomery Street',
  'street2' => '5th Floor',
  'city' => 'San Francisco',
  'state' => 'CA',
  'zip' => '94104',
  'phone' => '415-528-7555'
));
