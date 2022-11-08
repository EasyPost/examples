require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("<YOUR_PRODUCTION_API_KEY>");

$success = Billing::fund_wallet(2000, 'primary');
