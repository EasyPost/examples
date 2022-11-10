require_once("path/to/lib/easypost.php");
\EasyPost\EasyPost::setApiKey("<YOUR_TEST/PRODUCTION_API_KEY>");

$create_params = array(
    "url" => "http://example.com",
    "webhook_secret" => "A1B2C3"
);
$webhook = \EasyPost\Webhook::create($create_params);
